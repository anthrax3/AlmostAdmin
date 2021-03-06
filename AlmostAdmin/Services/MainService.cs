﻿using AlmostAdmin.Models;
using AlmostAdmin.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace AlmostAdmin.Services
{
    public class MainService
    {
        private MainRepository _mainRepository;

        public MainService(MainRepository mainRepository)
        {
            _mainRepository = mainRepository;
        }

        internal object GetListOfQuestions()
        {
            throw new NotImplementedException();
        }

        internal object GetListOfAnswers()
        {
            throw new NotImplementedException();
        }

        internal User GetUserByClaims(ClaimsPrincipal user)
        {
            return _mainRepository.GetUserByEmail(user.Identity.Name);
        }

        internal User GetUserByEmail(string userEmail)
        {
            return _mainRepository.GetUserByEmail(userEmail);
        }
        
        internal Project GetProjectById(int projectId)
        {
            return _mainRepository.GetProjectById(projectId);
        }
    }
}
