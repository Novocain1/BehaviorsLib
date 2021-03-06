using Vintagestory.API.Client;
using Vintagestory.API.Common;
using Vintagestory.GameContent;

namespace BehaviorsLib
{
    public class BehaviorsLib : ModSystem
	{
        public override void Start(ICoreAPI api)
		{
		    AiTaskManager.RegisterTaskType("AiTaskSleep", typeof(AiTaskSleep));
        }
        public override void StartClientSide(ICoreClientAPI api)
        {
           api.Logger.Notification("You are using BehaviorsLib");
        }
	}
}
