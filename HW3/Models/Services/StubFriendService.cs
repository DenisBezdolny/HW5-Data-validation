using HW4.Models.Abstract_entities;
using Microsoft.AspNetCore.Http.HttpResults;

namespace HW4.Models.Entities
{
    public class StubFriendService : IFriendService
    {
        public bool Create(FriendService friend)
        {
            throw new NotImplementedException();
        }

        public List<FriendService> GetFriends()
        {
            throw new NotImplementedException();
        }

        bool IFriendService.Create(Friend friend)
        {
            throw new NotImplementedException();
        }

        List<Friend> IFriendService.GetFriends()
        {
            throw new NotImplementedException();
        }

        void IFriendService.RemoveFriend(int friendId)
        {
            throw new NotImplementedException();
        }

        //public void CreateFriendsFile()
        //{
        //    return ;
        //}
    }
}
