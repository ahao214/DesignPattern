using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderSample
{
    /// <summary>
    /// 角色控制器,充当指挥者
    /// </summary>
    class ActorController
    {
        //逐步构建复杂产品对象
        public Actor Construct(ActorBuilder ab)
        {
            Actor actor;
            ab.BuildType();
            ab.BuildSex();
            ab.BuildFace();
            ab.BuildCostume();
            ab.BuildHairstyle();
            actor = ab.CreateActor();
            return actor;
        }
    }
}
