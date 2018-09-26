using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vintagestory.API;
using Vintagestory.API.Common;
using Vintagestory.GameContent;

namespace BehaviorsLib
{
    public class AiTaskSleep : AiTaskBase
    {
        public AiTaskSleep(EntityAgent entity) : base(entity)
        {
        }

        public float minDayLight;

        public override void LoadConfig(JsonObject taskConfig, JsonObject aiConfig)
        {
            if (taskConfig["mindaylight"] != null){
                minDayLight = taskConfig["mindaylight"].AsFloat();
            }

            base.LoadConfig(taskConfig, aiConfig);
        }

        public override bool ShouldExecute()
        {
            if (entity.World.Calendar.DayLightStrength < minDayLight) return false;
            return true;
        }

        public override void StartExecute()
        {
            base.StartExecute();        
        }

        public override bool ContinueExecute(float dt)
        {
            if (entity.World.Calendar.DayLightStrength < minDayLight) return false;
            return true;
        }
        
    }
}
