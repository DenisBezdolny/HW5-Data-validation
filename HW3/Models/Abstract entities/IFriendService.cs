using HW4.Models.Entities;
using System.Security.Cryptography;

namespace HW4.Models.Abstract_entities
{
    public interface IFriendService
    {
        bool Create(Friend friend);
        List<Friend> GetFriends();
        void RemoveFriend(int friendId);
    }
}
