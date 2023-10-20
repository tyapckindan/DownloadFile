using System.Diagnostics;

internal class Program
{
    private static async Task Main(string[] args)
    {
         HttpClient client = new();
         HttpResponseMessage response = await client.GetAsync("https://rur.hitmotop.com/get/music/20230331/Kravc_Gio_Pika_-_Gde_proshla_ty_75704918.mp3");
         byte[] data = await response.Content.ReadAsByteArrayAsync();
         await File.WriteAllBytesAsync("C:\\Users\\DELL\\Downloads\\А где прошла ты.mp3", data);

        Process.Start(new ProcessStartInfo { FileName = "C:\\Users\\DELL\\Downloads\\А где прошла ты.mp3", UseShellExecute = true });
    }
}