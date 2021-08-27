using System.Collections.Generic;

namespace aec_gama_api.Apresentacao
{
      public class HomeView
      {
          public string Mensagem
          {
              get{ return "API GRUPO MASTERS";}
          }

           public List<string> Endpoints
          {
             get
             { 
                 return new List<string>()
             {
                 "/candidatos",
                 "/profissoes",
                 "/swagger"
             };
          }
         }
      }
}