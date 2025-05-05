using AutoMapper;
using eUseControl.BussinesLogic.AppBL;
using eUseControl.Data.Entities.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using eUseControl.Data.Entities.Product;

namespace eUseControl.BussinesLogic.Core
{
    public class UserApi
    {

        internal List<UserTable> GetUsersListAction()
        {
            List<UserTable> users;
            using (var db = new TableContext())
            {
                users = db.Users.ToList();
            }
            return users;
        }

        internal List<BookTable> GetBooksListAction()
        {
            List<BookTable> books;
            using (var db = new TableContext())
            {
                books = db.Books.ToList();
            }
            return books;
        }
    }
}
