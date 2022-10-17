using System;
using System.Net;

public class Knife
{
    HttpListener listener = new HttpListener();

    public void _listener(string responseString, string s)//, params string[] prefixes)
    {
        if (!HttpListener.IsSupported)
        {
            Console.WriteLine("Your computer doesn't support Knife");
            return;
        }

        listener.Prefixes.Add(s);

        listener.Start();

        HttpListenerContext context = listener.GetContext();
        HttpListenerResponse response = context.Response;

        byte[] buffer = System.Text.Encoding.UTF8.GetBytes(responseString);
        response.ContentLength64 = buffer.Length;

        System.IO.Stream output = response.OutputStream;
        output.Write(buffer,0,buffer.Length);

        output.Close();
        listener.Stop();
    }

    public void stopListener()
    {
        listener.Stop();
    }
}
