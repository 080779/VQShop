using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VQShop.Service.Entities
{
    public class UserEntity:BaseEntity
    {
        public string Name { get; set; }
        public string PasswordSalt { get; set; }
        public string PasswordHash { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        /// <summary>
        /// 用户昵称
        /// </summary>
        public string NikeName { get; set; }
        /// <summary>
        /// 用户等级id
        /// </summary>
        public long UserRankId { get; set; }
        /// <summary>
        /// 用户头像地址
        /// </summary>
        public string UserIcoUrl { get; set; }
        public int 
    }
}
