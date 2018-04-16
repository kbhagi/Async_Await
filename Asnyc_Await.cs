Before
static void ReadFile(Stream fs)
{
var readBuffer = new byte[fs.length];
var   result = fs.BeginRead(readBuffer,0,(int)fs.Length, OnReadComplete,fs);
DisableUI();
}

private static void OnReadComplete(IAsyncResult result)
{
var fs = (FileStream)result.AsyncState;
var bytesRead = fs.EndRead(result);
fs.Dispose();
EnableUI();
}

static async Task ReadFile(Stream fs)
{
DisableUI();
var readBuffer = new byte[fs.length];
var result = await fs.ReadAsync(readBuffer,0,(int)fs.Length).ConfigureAwait(false);
EnableUI();
} 
