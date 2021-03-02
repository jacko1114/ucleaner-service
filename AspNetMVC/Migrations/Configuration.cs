namespace AspNetMVC.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
	using AspNetMVC.Models;
	using AspNetMVC.Models.Entity;

	internal sealed class Configuration : DbMigrationsConfiguration<AspNetMVC.Models.UCleanerDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AspNetMVC.Models.UCleanerDBContext context)
        {
			//  This method will be called after migrating to the latest version.

			//  You can use the DbSet<T>.AddOrUpdate() helper extension method 
			//  to avoid creating duplicate seed data. E.g.
			//
			//    context.People.AddOrUpdate(
			//      p => p.FullName,
			//      new Person { FullName = "Andrew Peters" },
			//      new Person { FullName = "Brice Lambson" },
			//      new Person { FullName = "Rowan Miller" }
			//    );
			//
			//context.RoomTypes.AddOrUpdate
			//	(x => x.RoomTypeId,
			//	new RoomType { Name = "�p��", Value = 0, CreateTime = DateTime.Now, CreateUser = "", EditTime = DateTime.Now, EditUser = "" },
			//	new RoomType {
			//		Name = "���U",
			//		Value = 1,
			//		CreateTime = DateTime.Now,
			//		CreateUser = "",
			//		EditTime = DateTime.Now,
			//		EditUser = ""
			//	},
			//	 new RoomType { Name = "�׫�", Value = 2, CreateTime = DateTime.Now, CreateUser = "", EditTime = DateTime.Now, EditUser = "" },
			//	new RoomType { Name = "�D�Z", Value = 3, CreateTime = DateTime.Now, CreateUser = "", EditTime = DateTime.Now, EditUser = "" },
			//	new RoomType { Name = "���x", Value = 4, CreateTime = DateTime.Now, CreateUser = "", EditTime = DateTime.Now, EditUser = "" }
			//);
			//context.ServiceItems.AddOrUpdate
			//  (
			//  x => x.ServiceitemId,
			//  new ServiceItem { Name = "�M��", Value = 0, CreateTime = DateTime.Now, CreateUser = "", EditTime = DateTime.Now, EditUser = "" },
			//  new ServiceItem { Name = "����", Value = 1, CreateTime = DateTime.Now, CreateUser = "", EditTime = DateTime.Now, EditUser = "" },
			//  new ServiceItem { Name = "����", Value = 2, CreateTime = DateTime.Now, CreateUser = "", EditTime = DateTime.Now, EditUser = "" }
			//  );
			//context.SquareFeets.AddOrUpdate
			//  (
			//  x => x.SquareFeetId,
			//  new SquareFeet { Name = "5�W�H�U", Value = 0, CreateTime = DateTime.Now, CreateUser = "", EditTime = DateTime.Now, EditUser = "" },
			//  new SquareFeet { Name = "6-10�W", Value = 1, CreateTime = DateTime.Now, CreateUser = "", EditTime = DateTime.Now, EditUser = "" },
			//  new SquareFeet { Name = "11-15�W", Value = 2, CreateTime = DateTime.Now, CreateUser = "", EditTime = DateTime.Now, EditUser = "" },
			//  new SquareFeet { Name = "16�W�H�W", Value = 3, CreateTime = DateTime.Now, CreateUser = "", EditTime = DateTime.Now, EditUser = "" }
			//  );
			//context.SingleProducts.AddOrUpdate(
			//   x => x.ProductId,
			//   new SingleProduct { Name = "�p�вM��", RoomType = 0, Squarefeet = 0, Hour = 1, Price = 500, PhotoUrl = "HQwLxRh.jpg", CreateTime = DateTime.Now, CreateUser = "", EditTime = DateTime.Now, EditUser = "" },
			//   new SingleProduct { Name = "�p�вM��", RoomType = 0, Squarefeet = 1, Hour = 1.5F, Price = 750, PhotoUrl = "HQwLxRh.jpg", CreateTime = DateTime.Now, CreateUser = "", EditTime = DateTime.Now, EditUser = "" },
			//   new SingleProduct { Name = "�p�вM��", RoomType = 0, Squarefeet = 2, Hour = 2, Price = 1000, PhotoUrl = "HQwLxRh.jpg", CreateTime = DateTime.Now, CreateUser = "", EditTime = DateTime.Now, EditUser = "" },
			//   new SingleProduct { Name = "�p�вM��", RoomType = 0, Squarefeet = 3, Hour = 2.5F, Price = 1250, PhotoUrl = "HQwLxRh.jpg", CreateTime = DateTime.Now, CreateUser = "", EditTime = DateTime.Now, EditUser = "" },
			//   new SingleProduct { Name = "���U�M��", RoomType = 1, Squarefeet = 0, Hour = 1, Price = 500, PhotoUrl = "Tvcj3OR.jpg", CreateTime = DateTime.Now, CreateUser = "", EditTime = DateTime.Now, EditUser = "" },
			//   new SingleProduct { Name = "���U�M��", RoomType = 1, Squarefeet = 1, Hour = 1.5F, Price = 750, PhotoUrl = "Tvcj3OR.jpg", CreateTime = DateTime.Now, CreateUser = "", EditTime = DateTime.Now, EditUser = "" },
			//   new SingleProduct { Name = "���U�M��", RoomType = 1, Squarefeet = 2, Hour = 2, Price = 1000, PhotoUrl = "Tvcj3OR.jpg", CreateTime = DateTime.Now, CreateUser = "", EditTime = DateTime.Now, EditUser = "" },
			//   new SingleProduct { Name = "���U�M��", RoomType = 1, Squarefeet = 3, Hour = 2.5F, Price = 1250, PhotoUrl = "Tvcj3OR.jpg", CreateTime = DateTime.Now, CreateUser = "", EditTime = DateTime.Now, EditUser = "" },
			//   new SingleProduct { Name = "�׫ǲM��", RoomType = 2, Squarefeet = 0, Hour = 1, Price = 500, PhotoUrl = "7hTQ5xR.jpg", CreateTime = DateTime.Now, CreateUser = "", EditTime = DateTime.Now, EditUser = "" },
			//   new SingleProduct { Name = "�׫ǲM��", RoomType = 2, Squarefeet = 1, Hour = 1.5F, Price = 750, PhotoUrl = "7hTQ5xR.jpg", CreateTime = DateTime.Now, CreateUser = "", EditTime = DateTime.Now, EditUser = "" },
			//   new SingleProduct { Name = "�׫ǲM��", RoomType = 2, Squarefeet = 2, Hour = 2, Price = 1000, PhotoUrl = "7hTQ5xR.jpg", CreateTime = DateTime.Now, CreateUser = "", EditTime = DateTime.Now, EditUser = "" },
			//   new SingleProduct { Name = "�׫ǲM��", RoomType = 2, Squarefeet = 3, Hour = 2.5F, Price = 1250, PhotoUrl = "7hTQ5xR.jpg", CreateTime = DateTime.Now, CreateUser = "", EditTime = DateTime.Now, EditUser = "" },
			//   new SingleProduct { Name = "�D�Z�M��", RoomType = 3, Squarefeet = 0, Hour = 0.5F, Price = 250, PhotoUrl = "7Z8nhs9.jpg", CreateTime = DateTime.Now, CreateUser = "", EditTime = DateTime.Now, EditUser = "" },
			//   new SingleProduct { Name = "�D�Z�M��", RoomType = 3, Squarefeet = 1, Hour = 1, Price = 500, PhotoUrl = "7Z8nhs9.jpg", CreateTime = DateTime.Now, CreateUser = "", EditTime = DateTime.Now, EditUser = "" },
			//   new SingleProduct { Name = "�D�Z�M��", RoomType = 3, Squarefeet = 2, Hour = 1.5F, Price = 750, PhotoUrl = "7Z8nhs9.jpg", CreateTime = DateTime.Now, CreateUser = "", EditTime = DateTime.Now, EditUser = "" },
			//   new SingleProduct { Name = "�D�Z�M��", RoomType = 3, Squarefeet = 3, Hour = 2F, Price = 1000, PhotoUrl = "7Z8nhs9.jpg", CreateTime = DateTime.Now, CreateUser = "", EditTime = DateTime.Now, EditUser = "" },
			//   new SingleProduct { Name = "���x�M��", RoomType = 4, Squarefeet = 0, Hour = 0.5F, Price = 250, PhotoUrl = "LewIn3G.jpg", CreateTime = DateTime.Now, CreateUser = "", EditTime = DateTime.Now, EditUser = "" },
			//   new SingleProduct { Name = "���x�M��", RoomType = 4, Squarefeet = 1, Hour = 1, Price = 500, PhotoUrl = "LewIn3G.jpg", CreateTime = DateTime.Now, CreateUser = "", EditTime = DateTime.Now, EditUser = "" },
			//   new SingleProduct { Name = "���x�M��", RoomType = 4, Squarefeet = 2, Hour = 1.5F, Price = 750, PhotoUrl = "LewIn3G.jpg", CreateTime = DateTime.Now, CreateUser = "", EditTime = DateTime.Now, EditUser = "" },
			//   new SingleProduct { Name = "���x�M��", RoomType = 4, Squarefeet = 3, Hour = 2F, Price = 1000, PhotoUrl = "LewIn3G.jpg", CreateTime = DateTime.Now, CreateUser = "", EditTime = DateTime.Now, EditUser = "" }
			//   );
			//context.PackageProducts.AddOrUpdate(
			//	x => x.PackageProductId,
			//	new PackageProduct { Name = "�p����O���P��", RoomType = 2, Squarefeet = 0, RoomType2 = 3, Squarefeet2 = 0, ServiceItem = "�M��+����", Hour = 1.5F, Price = 750, PhotoUrl = "o2VD8aZ.jpg", CreateTime = DateTime.Now, CreateUser = "", EditTime = DateTime.Now, EditUser = "" },
			//	new PackageProduct { Name = "�樭�Q�ڰ����i", RoomType = 2, Squarefeet = 1, RoomType2 = 3, Squarefeet2 = 0, ServiceItem = "�M��+����", Hour = 2, Price = 1000, PhotoUrl = "JL2pg7G.jpg", CreateTime = DateTime.Now, CreateUser = "", EditTime = DateTime.Now, EditUser = "" },
			//	new PackageProduct { Name = "��Ф@�U���n", RoomType = 2, Squarefeet = 2, RoomType2 = 1, Squarefeet2 = 1, RoomType3 = 3, Squarefeet3 = 0, ServiceItem = "�M��+����+����", Hour = 4, Price = 2000, PhotoUrl = "jcZDt0v.jpg", CreateTime = DateTime.Now, CreateUser = "", EditTime = DateTime.Now, EditUser = "" },
			//	new PackageProduct { Name = "�����b�b�p�a�x", RoomType = 1, Squarefeet = 1, RoomType2 = 0, Squarefeet2 = 1, RoomType3 = 2, Squarefeet3 = 2, ServiceItem = "�M��+����+����", Hour = 5, Price = 2500, PhotoUrl = "VRIwGhB.jpg", CreateTime = DateTime.Now, CreateUser = "", EditTime = DateTime.Now, EditUser = "" },
			//	new PackageProduct { Name = "�T�N�P��j�a�x", RoomType = 1, Squarefeet = 3, RoomType2 = 0, Squarefeet2 = 2, RoomType3 = 3, Squarefeet3 = 1, ServiceItem = "�M��+����+����", Hour = 6, Price = 3000, PhotoUrl = "F4OOvVQ.jpg", CreateTime = DateTime.Now, CreateUser = "", EditTime = DateTime.Now, EditUser = "" },
			//	new PackageProduct { Name = "�}��p�Ф@�_�b", RoomType = 1, Squarefeet = 2, RoomType2 = 0, Squarefeet2 = 1, ServiceItem = "�M��+����", Hour = 3.5F, Price = 1750, PhotoUrl = "uWZGaPB.jpg", CreateTime = DateTime.Now, CreateUser = "", EditTime = DateTime.Now, EditUser = "" },
			//	new PackageProduct { Name = "���x�p�ЫG����", RoomType = 0, Squarefeet = 1, RoomType2 = 4, Squarefeet2 = 1, ServiceItem = "�M��+����", Hour = 2.5F, Price = 1250, PhotoUrl = "k19BwYr.jpg", CreateTime = DateTime.Now, CreateUser = "", EditTime = DateTime.Now, EditUser = "" },
			//	new PackageProduct { Name = "���U�׫ǳ̾��", RoomType = 1, Squarefeet = 2, RoomType2 = 2, Squarefeet2 = 1, ServiceItem = "�M��+����", Hour = 3.5F, Price = 1750, PhotoUrl = "qf87eZM.jpg", CreateTime = DateTime.Now, CreateUser = "", EditTime = DateTime.Now, EditUser = "" },
			//	new PackageProduct { Name = "�D�Z���x�p����", RoomType = 3, Squarefeet = 1, RoomType2 = 4, Squarefeet2 = 0, ServiceItem = "�M��+����", Hour = 1.5F, Price = 750, PhotoUrl = "HOoGu7u.jpg", CreateTime = DateTime.Now, CreateUser = "", EditTime = DateTime.Now, EditUser = "" }
			//	);
			//context.UserFavorites.AddOrUpdate(
			//  x => x.FavoriteId,
			//  new UserFavorite { FavoriteId = Guid.NewGuid(), AccountId = Guid.NewGuid(), UserDefinedId = null, PackageProductId = 3, IsPakage = true, IsDelete = false, CreateTime = DateTime.Now, CreateUser = "", EditTime = DateTime.Now, EditUser = "" }
			//new UserFavorite { AccountId = Guid.NewGuid(), UserDefinedId = null, PackageProductId = 4 , IsPakage = true, IsDelete = false, CreateTime = DateTime.Now, CreateUser = "", EditTime = DateTime.Now, EditUser = "" },
			//new UserFavorite { AccountId = Guid.NewGuid(), UserDefinedId = null, PackageProductId = 5, IsPakage = true, IsDelete = false, CreateTime = DateTime.Now, CreateUser = "", EditTime = DateTime.Now, EditUser = "" }
			//);
		}
    }
}
