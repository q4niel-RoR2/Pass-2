using BepInEx;

namespace Pass_2 {
    [BepInPlugin("q4niel.pass2", "Pass 2", "0.0.0")]
    public class Pass2 : BaseUnityPlugin {
        public void Awake()
            => Logger.LogInfo("Pass 2 Init");
    }
}