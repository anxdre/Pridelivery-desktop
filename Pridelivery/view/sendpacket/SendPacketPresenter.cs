using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using Pridelivery.Repository;

namespace Pridelivery.view.sendpacket
{
    internal class SendPacketPresenter
    {
        MySqlConnection connection = DbConnector.Instance.createConnection();
    }
}
