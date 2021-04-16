using LOGIC.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LOGICInterfaces
{
    public interface IGroupCollection
    {
        void CreateGroup(Group group);
        List<Group> GetFroups();
    }
}
