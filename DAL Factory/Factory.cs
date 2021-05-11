using DAL.APIContext;
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
        private static IRequester _requesterConnectionHandler;

        public static IUserHandler UserConnectionHandler
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

        public static IGroupHandler GroupConnectionHandler
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

        public static IRequester RequesterConnectionHandler
        {
            get
            {
                if (_requesterConnectionHandler == null)
                {
                    _requesterConnectionHandler = new Requester(new APIKeyHandler());
                }
                return _requesterConnectionHandler;
            }
        }
    }
}
