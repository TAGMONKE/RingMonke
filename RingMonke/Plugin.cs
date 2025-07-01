namespace RingMonke
{
    [BepInEx.BepInPlugin("com.RingMonkeTeam.RingMonke.live", "RingMonke", BasicVariables.VersionLocal)]
    internal class Plugin : BepInEx.BaseUnityPlugin
    {
        private void Awake()
        {
            GorillaTagger.OnPlayerSpawned(OnGameInit);
        }

        private void OnGameInit()
        {
            System.Console.Title = $"RingMonke {BasicVariables.VersionLocal}";
            UnityEngine.Debug.Log($"RingMonke | Version {BasicVariables.VersionLocal}");
        }
        private void SummonError(string issue)
        {
            bool Flag = issue == null;
            if (!Flag)
            {
                GorillaNetworking.GorillaComputer.instance.GeneralFailureMessage(issue);
                //Photon.Pun.PhotonNetwork.Disconnect();
                NetworkSystem.Instance.ReturnToSinglePlayer();
                BasicVariables.DisconnectFromNetwork();
            }
        }
    }
}
//rah