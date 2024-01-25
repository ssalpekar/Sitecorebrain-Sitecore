using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumitsProject.Foundation.Pardot.ViewModel
{
    [Serializable]
    public class PardotEndpointViewModel : StringInputViewModel
    {
        protected override void InitItemProperties(Item item)
        {
            base.InitItemProperties(item);
            Rendering rendering = RenderingContext.CurrentOrNull?.Rendering;
            string endpointUrl = rendering?.Parameters[<Field_Name_OR_ID>];
            InitializeValue(endpointUrl);
        }
    }
}
