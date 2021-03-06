﻿using DAL.Repositories.Declarations;
using Models;
using System;
using System.Collections.Generic;
using DAL.Repositories;

namespace Services.Services {
    public class FriendsService : IFriendsService {
        private readonly IFriendRepository _friendRepository;

        public FriendsService(IFriendRepository friendRepository) {
            _friendRepository = friendRepository;
        }

        public IEnumerable<FriendModel> GetAllFriends() {          
            return _friendRepository.GetAll();
        }

        public void RemoveFriends(List<int> ids) {
            _friendRepository.RemoveRange(ids);
            _friendRepository.Commit();
        }

        public void AddFriends(List<FriendModel> friends) {
            _friendRepository.AddRange(friends);
            _friendRepository.Commit();
        }

        public List<FriendModel> GetFeastFriends() {
            return _friendRepository.GetFeastFriends();
        }
    }
}
