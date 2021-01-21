using MLAPI;
using MLAPI.Transports.UNET;
using UnityEngine.UI;

public class NetworkManager : NetworkedBehaviour
{

    public Text ipAddress;
    public int port = 7777;

    public void JoinGame()
    {
        // add more checkers for a valid ip address, otherwise throw special error
        if (ipAddress != null)
        {
            NetworkingManager.Singleton.GetComponent<UnetTransport>().ConnectAddress = ipAddress.text;
            NetworkingManager.Singleton.GetComponent<UnetTransport>().ConnectPort = port;
            NetworkingManager.Singleton.StartClient();
        }
    }

    public void HostGame()
    {
        NetworkingManager.Singleton.GetComponent<UnetTransport>().ConnectAddress = "128.61.84.237";
        NetworkingManager.Singleton.GetComponent<UnetTransport>().ConnectPort = port;
        NetworkingManager.Singleton.StartHost();
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
