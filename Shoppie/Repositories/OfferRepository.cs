﻿using Shoppie.Interfaces;

namespace Shoppie.Repositories
{
    public class OfferRepository : IOfferRepository
    {
        private readonly ApplicationDbContext _context;
        public OfferRepository(ApplicationDbContext context)
        {
            _context= context;
        }

        public IQueryable<Offer> GetAllOffers()
        {
            return _context.Offers;
        }
        public IQueryable<Offer> GetAllActiveOffers()
        {
            return _context.Offers.Where(o => o.IsActive);
        }

        public IQueryable<Offer> GetDiscountedOffers()
        {
            return _context.Offers.Where(o => o.Discount > 0);
        }

        public IQueryable<Offer> GetNewOffers(int count)
        {
           return _context.Offers.OrderByDescending(o => o.CreationDate).Take(count);
        }

        public IQueryable<Offer> GetUsersOffers(string userId)
        {
            return _context.Offers.Where(o => o.OwnerId == userId);
        }
    }
}