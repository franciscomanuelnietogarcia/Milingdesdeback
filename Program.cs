using Milingdesdeback;

static void Main(string[] args)
{
    logic objLogic = new logic();
    string body = @"<style>
                            h1{color:dodgerblue;}
                            h2{color:darkorange;}
                            </style>
                            <h1>Este es el body del correo</h1></br>
                            <h2>Este es el segundo párrafo</h2>";
    objLogic.sendMail("pruebaparamailing80@gmail.com", "Este correo fue enviado via C-sharp", body);
}



