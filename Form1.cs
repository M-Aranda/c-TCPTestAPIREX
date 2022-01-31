using NPOI.SS.Formula.Functions;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;





namespace testApiRex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private  void button1_Click(object sender, EventArgs e)
        {






        }


        private async Task contactarAPI()
        {
            var client = new RestClient("{{transpcargo.rexmas.cl }}/v2/aliados/configuracion/cambiar_clave");
           // client.Timeout = -1;
            var request = new RestRequest();//Method.PUT
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", "Token {{token-ally}}");
            var body = @"{" + "\n" +
            @"	""clave_antigua"": ""AbAb12345""," + "\n" +
            @"	""clave_nueva"": ""{{clave_bases}""," + "\n" +
            @"	""confirmacion_clave_nueva"": ""{{clave_bases}}""" + "\n" +
            @"}";
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            RestResponse response = client.ExecuteAsync<>(request);
            Console.WriteLine(response.Content);
        }
    }
}
