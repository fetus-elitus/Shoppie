﻿using Shoppie.ViewModels;

namespace Shoppie.Interfaces
{
    public interface IOfferService
    {
        Task<List<OfferVM>> GetAllOffers();
        Task<List<OfferVM>> GetNewOffers(int count);
        Task<List<OfferVM>> GetDiscountedOffers();
        Task<List<OfferVM>> GetAllActiveOffers();
        Task<List<OfferVM>> GetUsersOffers(string userId);

    }
}
