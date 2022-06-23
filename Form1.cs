using System;
using System.Net;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Windows.Forms;
using RestSharp;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

#pragma warning disable IDE0018 // Inline variable declaration
#pragma warning disable IDE1006 // Naming Styles
namespace RestSharpApplication1
{
    public partial class Form1 : Form
    {
        string strServer = "";
        string strUserID = "";
        string strPassword = "";
        string strResource = "";
        string strMethod = "";
        string strXAuthToken = "";
        string strFileName = "";
        struct auth_struct
        {
            public string X_Auth_Token;
            public int    max_age;
            public string persona;
            public struct user
            {
                public string email, full_name, user_id;
            }
        };        // unused struct

        public Form1()
        {
            InitializeComponent();

            strServer = textServer.Text;
            strUserID = textUserID.Text;
            strPassword = textPassword.Text;
            strResource = comboResource.Text;
            strMethod = "PUT";
        }

        private void textServer_TextChanged(object sender, EventArgs e)
        {
            strServer = textServer.Text;
        }

        private void textUserID_TextChanged(object sender, EventArgs e)
        {
            strUserID = textUserID.Text;
            strXAuthToken = "";
        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {
            strPassword = textPassword.Text;
            strXAuthToken = "";
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            // http://stackoverflow.com/questions/32788409/c-sharp-httpwebrequest-the-underlying-connection-was-closed-an-unexpected-error
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            var client = new RestClient("https://" + strServer);
            Debug.WriteLine(client.BaseUrl.Port + "\n" + ServicePointManager.SecurityProtocol.ToString());

            Method method = Method.PUT;               // default HTTP method
            if (strMethod == "GET")
                method = Method.GET;
            if (strMethod == "POST")
                method = Method.POST;
            if (strMethod == "PATCH")
                method = Method.PATCH;
            if (strMethod == "DELETE")
                method = Method.DELETE;

            // Create request based on the resource and method
            var request = new RestRequest(strResource, method);
            request.AddHeader("Content-Type", "application/json");

            // If we haven't logged-in yet:
            if (strXAuthToken == "")
            {
                // create a dictionary containing name/value pairs
                var credentials = new Dictionary<string, string>()
                {
                    { "userid", strUserID },
                    { "password", strPassword }
                };

                // debug testing: serialize the credentials object and write to VS output window
                string strJsonBody = SimpleJson.SerializeObject(credentials);
                Debug.WriteLine(strJsonBody);

                // automatically serializes the credentials object and adds to the request body
                request.AddJsonBody(credentials);

                strJsonBody = SimpleJson.SerializeObject(authentication_json());
                Debug.WriteLine(strJsonBody);
                request.AddJsonBody(authentication_json());
            }
            else
            {
                // easily add HTTP Headers
                request.AddHeader("Authorization", "Bearer " + strXAuthToken);
                request.AddHeader("Cookie", "X-Login-Type=imanage");
                //request.RequestFormat = DataFormat.Json;
            }

            // add files to upload (works with compatible verbs)
            if (strFileName != "")
                request.AddFile("file", strFileName);

            // execute the request
            IRestResponse response = client.Execute(request);
            var content = response.Content;             // raw content as string
            Debug.WriteLine(content);

            if (content != "")                          // something was returned
            {
                try
                {
                    Dictionary<string, object> deserialized_obj = SimpleJson.DeserializeObject<Dictionary<string, object>>(content);

                    // check for an error key
                    if (deserialized_obj.ContainsKey("error"))
                        listResponse.Items.Add(deserialized_obj["error"].ToString());
                    else
                    {
                        // have you logged in yet, i.e. do we have an empty token?
                        if (strXAuthToken == "")
                        {
                            object obj1;
                            bool bSuccess = SimpleJson.TryDeserializeObject(content, out obj1);

                            JObject obj2 = (JObject)JsonConvert.DeserializeObject(content);
                            JProperty jprop = (JProperty)obj2.First;
                            if (jprop.Name == "X-Auth-Token")
                                strXAuthToken = (string)jprop.Value;

                            foreach (string key in deserialized_obj.Keys)
                                listResponse.Items.Add("[" + key + "]:  \t" + deserialized_obj[key].ToString());
                        }
                        else
                        // some other method was invoked, ASSUMES an array of objects (documents / workspaces / folders) were returned
                        {
                            if (deserialized_obj.ContainsKey("data"))
                            {
                                JObject obj3 = (JObject)JsonConvert.DeserializeObject(content);
                                JProperty data_prop = (JProperty)obj3.First;
                                JArray data = (JArray)data_prop.First;
                                Debug.WriteLine("count: " + data.Count);

                                if (data.Count > 0)
                                {
                                    JToken array = data[0];
                                    foreach (string userid in data.Values("userid"))
                                        Debug.WriteLine(userid);

                                    listResponse.Items.Clear();
                                    foreach (JObject obj in data)
                                    {
                                        JToken token_value;
                                        bool bSuccess = obj.TryGetValue("name", out token_value);
                                        if (bSuccess)
                                            listResponse.Items.Add(string.Format("{0} - {1}", obj["id"].ToString(), token_value.ToString()));
                                        else
                                            listResponse.Items.Add(string.Format("{0} - {1} - {2}", obj["user_id"], obj["full_name"], obj["email"]));
                                    }
                                }
                                else
                                {
                                    listResponse.Items.Clear();
                                    listResponse.Items.Add("data[] == null");
                                }

                            }
                            if (deserialized_obj.ContainsKey("ServerVersion"))
                            {
                                Debug.WriteLine("count: " + deserialized_obj.Count);
                                foreach (KeyValuePair<string, object> kvp in deserialized_obj)
                                    listResponse.Items.Add(string.Format("{0} - {1}", kvp.Key, kvp.Value));
                            }
                        }   // if (strXAuthToken
                    }   // if (
                }
                catch (SerializationException ex)
                {
                    listResponse.Items.Add(ex.Message + "\t**************\tDid you use the right VERB?\t**************");
                }
                catch (NullReferenceException ex)
                {
                    listResponse.Items.Add(ex.Message);
                }
            }
        }   // void btnExecute_Click

        private void comboMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            strMethod = comboMethod.Text;
        }

        private void comboResource_SelectedIndexChanged(object sender, EventArgs e)
        {
            strResource = comboResource.Text;
            if (comboResource.SelectedIndex == 0)
                strXAuthToken = "";
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog open_dialog = new OpenFileDialog();

            if (open_dialog.ShowDialog() == DialogResult.OK)
            {
                strFileName = open_dialog.FileName;
                textFileName.Text = strFileName;
            }
        }

        private Dictionary<string, object> authentication_json()
        {
            var auth = new Dictionary<string, string>()
            {
                { "appUuid", Guid.NewGuid().ToString() },
                { "domain", "" },
                { "password", strPassword },
                { "userID", strUserID }
            };
            var encap = new Dictionary<string, object>()
            {
                { "Authentication", auth }
            };

            return encap;
        }
    }
}
#pragma warning restore IDE0018 // Inline variable declaration
#pragma warning restore IDE1006 // Naming Styles
