using Vintagestory.API;
using Vintagestory.API.Common;

namespace BehaviorsLib
{
    public class AiTaskSleep : AiTaskBase
    {
        public AiTaskSleep(EntityAgent entity) : base(entity)
        {
        }

        public bool isNocturnal = true;

        public override void LoadConfig(JsonObject taskConfig, JsonObject aiConfig)
        {
            if (taskConfig["isnocturnal"] != null){
                isNocturnal = taskConfig["isnocturnal"].AsBool(true);
            }

            base.LoadConfig(taskConfig, aiConfig);
        }

        public override bool ShouldExecute()
        {
            if (isNocturnal && entity.World.Calendar.DayLightStrength > 0.50f || !isNocturnal && entity.World.Calendar.DayLightStrength < 0.50f) return true;
            return false;
        }

        public override void StartExecute()
        {
            base.StartExecute();
        }

        public override bool ContinueExecute(float dt)
        {
            if (isNocturnal && entity.World.Calendar.DayLightStrength > 0.50f || !isNocturnal && entity.World.Calendar.DayLightStrength < 0.50f) return true;
            return false;
        }
        
    }
}
