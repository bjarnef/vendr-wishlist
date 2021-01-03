﻿using Vendr.Contrib.Wishlists.Models;
using Vendr.Core.Events.Notification;

namespace Vendr.Contrib.Wishlists.Events
{
    public class WishlistNotificationBase : NotificationEventBase
    {
        public Wishlist Wishlist { get; }

        public WishlistNotificationBase(Wishlist wishlist)
        {
            Wishlist = wishlist;
        }
    }

    public class WishlistAddingNotification : WishlistNotificationBase
    {
        public WishlistAddingNotification(Wishlist wishlist)
          : base(wishlist)
        { }
    }

    public class WishlistAddedNotification : WishlistNotificationBase
    {
        public WishlistAddedNotification(Wishlist wishlist)
          : base(wishlist)
        { }
    }
}