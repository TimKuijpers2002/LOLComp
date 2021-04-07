using DAL.DataContext;
using Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL_Factory
{
    public static class Factory
    {
        private static IUserHandler _userConnectionHandler;
        private static IGroupHandler _groupConnectionHandler;

        public static IUserHandler userConnectionHandler
        {
            get
            {
                if (_userConnectionHandler == null)
                {
                    _userConnectionHandler = new UserHandler(new DBConnectionHandler());
                }
                return _userConnectionHandler;
            }
        }

        public static IGroupHandler groupConnectionHandler
        {
            get
            {
                if (_groupConnectionHandler == null)
                {
                    _groupConnectionHandler = new GroupHandler(new DBConnectionHandler());
                }
                return _groupConnectionHandler;
            }
        }
    }
}
