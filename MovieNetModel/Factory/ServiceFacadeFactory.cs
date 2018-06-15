using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieNetModel.Interface;

namespace MovieNetModel.Factory
{
    public class ServiceFacadeFactory
    {
        static public IServiceFacade getServiceFacade()
        {
            IServiceFacade serviceFacade = null;

            if (serviceFacade == null)
            {
                serviceFacade = Service.ServiceFacade.Instance;
            }

            return serviceFacade;
        }
    }
}
