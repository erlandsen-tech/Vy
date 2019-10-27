using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VyBillettBestilling.BLL;
using VyBillettBestilling.Controllers;

namespace EnhetsTest
{
    class ManageControllerTest
    {
        [TestMethod]
        public void Administrasjon()
        {
            var controller = new ManageController(new DbTilgangSTUB());
        }
    }
}
