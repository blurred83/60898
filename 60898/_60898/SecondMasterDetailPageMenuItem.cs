using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _60898
{

    public class SecondMasterDetailPageMenuItem
    {
        public SecondMasterDetailPageMenuItem()
        {
            TargetType = typeof(SecondMasterDetailPageDetail);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}