using Photon.Pun;

namespace RingMonke
{
    internal class Networking
    {
        public void Awake()
        {
            PhotonNetwork.LocalPlayer.CustomProperties.Add("RingMonke", true);
        }
    }
}
