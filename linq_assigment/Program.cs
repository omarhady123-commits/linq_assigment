using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace linq_assigment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var categories = new List<Category>
                {
                    new() { Id = 1, Name = "Laptops" },
                    new() { Id = 2, Name = "Phones" },
                    new() { Id = 3, Name = "Accessories" },
                    new() { Id = 4, Name = "Monitors" }
                };

            var products = new List<Product>
                {
                    new() { Id = 1, Name = "Dell XPS", Price = 1500, Stock = 10, CategoryId = 1, Category = categories[0] },
                    new() { Id = 2, Name = "HP Victus", Price = 1200, Stock = 5, CategoryId = 1, Category = categories[0] },
                    new() { Id = 3, Name = "Lenovo ThinkPad", Price = 1800, Stock = 3, CategoryId = 1, Category = categories[0] },
                    new() { Id = 4, Name = "iPhone 16", Price = 1000, Stock = 15, CategoryId = 2, Category = categories[1] },
                    new() { Id = 5, Name = "Samsung S25", Price = 900, Stock = 12, CategoryId = 2, Category = categories[1] },
                    new() { Id = 6, Name = "Mouse", Price = 20, Stock = 2, CategoryId = 3, Category = categories[2] },
                    new() { Id = 7, Name = "Keyboard", Price = 40, Stock = 1, CategoryId = 3, Category = categories[2] },
                    new() { Id = 8, Name = "Headphones", Price = 80, Stock = 10, CategoryId = 3, Category = categories[2] },
                    new() { Id = 9, Name = "Samsung Monitor", Price = 350, Stock = 7, CategoryId = 4, Category = categories[3] },
                    new() { Id = 10, Name = "Gaming Chair", Price = 250, Stock = 5, CategoryId = 3, Category = categories[2] }
                };

            var customers = new List<Customer>
        {
            new() { Id = 1, FullName = "Ahmed Ali", Email = "ahmed@test.com", City = "Assiut", RegisteredAt = new DateTime(2026, 10, 1) },
            new() { Id = 2, FullName = "Mohamed Hassan", Email = "mohamed@test.com", City = "Cairo", RegisteredAt = new DateTime(2025, 5, 10) },
            new() { Id = 3, FullName = "Sara Mohamed", Email = "sara@test.com", City = "Assiut", RegisteredAt = new DateTime(2026, 10, 5) },
            new() { Id = 4, FullName = "Omar Samir", Email = "omar@test.com", City = "Giza", RegisteredAt = new DateTime(2024, 3, 15) },
            new() { Id = 5, FullName = "Mona Adel", Email = "mona@test.com", City = "Cairo", RegisteredAt = new DateTime(2026, 9, 28) },
            new() { Id = 6, FullName = "Ali Mahmoud", Email = "ali@test.com", City = "Alexandria", RegisteredAt = new DateTime(2025, 1, 20) },
            new() { Id = 7, FullName = "Nour Khaled", Email = "nour@test.com", City = "Assiut", RegisteredAt = new DateTime(2026, 10, 8) },
            new() { Id = 8, FullName = "Youssef Tarek", Email = "youssef@test.com", City = "Giza", RegisteredAt = new DateTime(2024, 6, 20) },
            new() { Id = 9, FullName = "Salma Mostafa", Email = "salma@test.com", City = "Cairo", RegisteredAt = new DateTime(2026, 9, 25) },
            new() { Id = 10, FullName = "Hany Fathy", Email = "hany@test.com", City = "Assiut", RegisteredAt = new DateTime(2025, 1, 10) }
        };

            var orders = new List<Order>
        {
            new() { Id = 1, CustomerId = 1, Customer = customers[0], OrderDate = new DateTime(2025, 1, 10), Status = OrderStatus.Delivered },
            new() { Id = 2, CustomerId = 1, Customer = customers[0], OrderDate = new DateTime(2025, 2, 15), Status = OrderStatus.Delivered },
            new() { Id = 3, CustomerId = 1, Customer = customers[0], OrderDate = new DateTime(2025, 3, 20), Status = OrderStatus.Pending },
            new() { Id = 4, CustomerId = 2, Customer = customers[1], OrderDate = new DateTime(2025, 1, 25), Status = OrderStatus.Delivered },
            new() { Id = 5, CustomerId = 2, Customer = customers[1], OrderDate = new DateTime(2025, 4, 5), Status = OrderStatus.Cancelled },
            new() { Id = 6, CustomerId = 2, Customer = customers[1], OrderDate = new DateTime(2025, 5, 10), Status = OrderStatus.Cancelled },
            new() { Id = 7, CustomerId = 2, Customer = customers[1], OrderDate = new DateTime(2025, 6, 12), Status = OrderStatus.Cancelled },
            new() { Id = 8, CustomerId = 3, Customer = customers[2], OrderDate = new DateTime(2025, 2, 5), Status = OrderStatus.Delivered },
            new() { Id = 9, CustomerId = 3, Customer = customers[2], OrderDate = new DateTime(2025, 7, 8), Status = OrderStatus.Shipped },
            new() { Id = 10, CustomerId = 4, Customer = customers[3], OrderDate = new DateTime(2025, 3, 11), Status = OrderStatus.Delivered },
            new() { Id = 11, CustomerId = 4, Customer = customers[3], OrderDate = new DateTime(2025, 8, 19), Status = OrderStatus.Delivered },
            new() { Id = 12, CustomerId = 5, Customer = customers[4], OrderDate = new DateTime(2025, 4, 22), Status = OrderStatus.Delivered },
            new() { Id = 13, CustomerId = 5, Customer = customers[4], OrderDate = new DateTime(2025, 9, 1), Status = OrderStatus.Pending },
            new() { Id = 14, CustomerId = 6, Customer = customers[5], OrderDate = new DateTime(2025, 5, 17), Status = OrderStatus.Delivered },
            new() { Id = 15, CustomerId = 7, Customer = customers[6], OrderDate = new DateTime(2025, 6, 25), Status = OrderStatus.Delivered },
            new() { Id = 16, CustomerId = 8, Customer = customers[7], OrderDate = new DateTime(2025, 7, 30), Status = OrderStatus.Delivered }
        };

            var orderItems = new List<OrderItem>
        {
            new() { Id = 1, OrderId = 1, Order = orders[0], ProductId = 1, Product = products[0], Quantity = 1, UnitPrice = 1500, Discount = 0.10m },
            new() { Id = 2, OrderId = 1, Order = orders[0], ProductId = 6, Product = products[5], Quantity = 2, UnitPrice = 20, Discount = 0m },
            new() { Id = 3, OrderId = 1, Order = orders[0], ProductId = 7, Product = products[6], Quantity = 1, UnitPrice = 40, Discount = 0m },
            new() { Id = 4, OrderId = 2, Order = orders[1], ProductId = 2, Product = products[1], Quantity = 1, UnitPrice = 1200, Discount = 0m },
            new() { Id = 5, OrderId = 2, Order = orders[1], ProductId = 8, Product = products[7], Quantity = 1, UnitPrice = 80, Discount = 0.10m },
            new() { Id = 6, OrderId = 3, Order = orders[2], ProductId = 6, Product = products[5], Quantity = 8, UnitPrice = 20, Discount = 0m },
            new() { Id = 7, OrderId = 3, Order = orders[2], ProductId = 7, Product = products[6], Quantity = 5, UnitPrice = 40, Discount = 0m },
            new() { Id = 8, OrderId = 4, Order = orders[3], ProductId = 4, Product = products[3], Quantity = 2, UnitPrice = 1000, Discount = 0.05m },
            new() { Id = 9, OrderId = 4, Order = orders[3], ProductId = 5, Product = products[4], Quantity = 1, UnitPrice = 900, Discount = 0m },
            new() { Id = 10, OrderId = 5, Order = orders[4], ProductId = 1, Product = products[0], Quantity = 1, UnitPrice = 1500, Discount = 0m },
            new() { Id = 11, OrderId = 6, Order = orders[5], ProductId = 2, Product = products[1], Quantity = 1, UnitPrice = 1200, Discount = 0m },
            new() { Id = 12, OrderId = 7, Order = orders[6], ProductId = 3, Product = products[2], Quantity = 1, UnitPrice = 1800, Discount = 0m },
            new() { Id = 13, OrderId = 8, Order = orders[7], ProductId = 1, Product = products[0], Quantity = 1, UnitPrice = 1500, Discount = 0m },
            new() { Id = 14, OrderId = 8, Order = orders[7], ProductId = 2, Product = products[1], Quantity = 1, UnitPrice = 1200, Discount = 0m },
            new() { Id = 15, OrderId = 8, Order = orders[7], ProductId = 6, Product = products[5], Quantity = 3, UnitPrice = 20, Discount = 0m },
            new() { Id = 16, OrderId = 9, Order = orders[8], ProductId = 5, Product = products[4], Quantity = 2, UnitPrice = 900, Discount = 0m },
            new() { Id = 17, OrderId = 10, Order = orders[9], ProductId = 3, Product = products[2], Quantity = 2, UnitPrice = 1800, Discount = 0.10m },
            new() { Id = 18, OrderId = 10, Order = orders[9], ProductId = 9, Product = products[8], Quantity = 1, UnitPrice = 350, Discount = 0m },
            new() { Id = 19, OrderId = 11, Order = orders[10], ProductId = 4, Product = products[3], Quantity = 1, UnitPrice = 2000, Discount = 0m },
            new() { Id = 20, OrderId = 11, Order = orders[10], ProductId = 9, Product = products[8], Quantity = 2, UnitPrice = 400, Discount = 0.05m },
            new() { Id = 21, OrderId = 12, Order = orders[11], ProductId = 4, Product = products[3], Quantity = 1, UnitPrice = 1000, Discount = 0m },
            new() { Id = 22, OrderId = 12, Order = orders[11], ProductId = 8, Product = products[7], Quantity = 2, UnitPrice = 80, Discount = 0m },
            new() { Id = 23, OrderId = 13, Order = orders[12], ProductId = 6, Product = products[5], Quantity = 4, UnitPrice = 20, Discount = 0m },
            new() { Id = 24, OrderId = 13, Order = orders[12], ProductId = 7, Product = products[6], Quantity = 3, UnitPrice = 40, Discount = 0m },
            new() { Id = 25, OrderId = 14, Order = orders[13], ProductId = 5, Product = products[4], Quantity = 3, UnitPrice = 300, Discount = 0.10m },
            new() { Id = 26, OrderId = 15, Order = orders[14], ProductId = 5, Product = products[4], Quantity = 1, UnitPrice = 900, Discount = 0m },
            new() { Id = 27, OrderId = 16, Order = orders[15], ProductId = 1, Product = products[0], Quantity = 1, UnitPrice = 1500, Discount = 0m },
            new() { Id = 28, OrderId = 16, Order = orders[15], ProductId = 6, Product = products[5], Quantity = 2, UnitPrice = 20, Discount = 0m }
        };

            var reviews = new List<Review>
        {
            new() { Id = 1, ProductId = 1, Product = products[0], CustomerId = 1, Customer = customers[0], Rating = 5, Comment = "Excellent", CreatedAt = new DateTime(2025, 1, 1) },
            new() { Id = 2, ProductId = 1, Product = products[0], CustomerId = 2, Customer = customers[1], Rating = 5, Comment = "Great", CreatedAt = new DateTime(2025, 1, 2) },
            new() { Id = 3, ProductId = 1, Product = products[0], CustomerId = 3, Customer = customers[2], Rating = 5, Comment = "Amazing", CreatedAt = new DateTime(2025, 1, 3) },
            new() { Id = 4, ProductId = 1, Product = products[0], CustomerId = 4, Customer = customers[3], Rating = 5, Comment = "Very good", CreatedAt = new DateTime(2025, 1, 4) },
            new() { Id = 5, ProductId = 1, Product = products[0], CustomerId = 5, Customer = customers[4], Rating = 5, Comment = "Perfect", CreatedAt = new DateTime(2025, 1, 5) },
            new() { Id = 6, ProductId = 1, Product = products[0], CustomerId = 6, Customer = customers[5], Rating = 4, Comment = "Good", CreatedAt = new DateTime(2025, 1, 6) },
            new() { Id = 7, ProductId = 1, Product = products[0], CustomerId = 7, Customer = customers[6], Rating = 5, Comment = "Nice", CreatedAt = new DateTime(2025, 1, 7) },
            new() { Id = 8, ProductId = 1, Product = products[0], CustomerId = 8, Customer = customers[7], Rating = 5, Comment = "Super", CreatedAt = new DateTime(2025, 1, 8) },
            new() { Id = 9, ProductId = 1, Product = products[0], CustomerId = 9, Customer = customers[8], Rating = 5, Comment = "Excellent", CreatedAt = new DateTime(2025, 1, 9) },
            new() { Id = 10, ProductId = 1, Product = products[0], CustomerId = 10, Customer = customers[9], Rating = 5, Comment = "Recommended", CreatedAt = new DateTime(2025, 1, 10) },
            new() { Id = 11, ProductId = 2, Product = products[1], CustomerId = 9, Customer = customers[8], Rating = 2, Comment = "Not for me", CreatedAt = new DateTime(2025, 2, 1) },
            new() { Id = 12, ProductId = 5, Product = products[4], CustomerId = 1, Customer = customers[0], Rating = 4, Comment = "Good phone", CreatedAt = new DateTime(2025, 2, 2) }
        };

            foreach (var customer in customers)
            {
                customer.Orders = orders.Where(o => o.CustomerId == customer.Id).ToList();
                customer.Reviews = reviews.Where(r => r.CustomerId == customer.Id).ToList();
            }

            foreach (var product in products)
            {
                product.OrderItems = orderItems.Where(i => i.ProductId == product.Id).ToList();
                product.Reviews = reviews.Where(r => r.ProductId == product.Id).ToList();
            }

            foreach (var category in categories)
            {
                category.Products = products.Where(p => p.CategoryId == category.Id).ToList();
            }

            foreach (var order in orders)
            {
                order.Items = orderItems.Where(i => i.OrderId == order.Id).ToList();
            }

            // 1
            var res1 = orders.Where(o => o.Status == OrderStatus.Delivered)
                             .Select(o => new
                             {
                                 OrderId = o.Id,
                                 CustomerName = o.Customer.FullName,
                                 Total = o.Items.Sum(i => i.Quantity * i.UnitPrice * (1 - i.Discount))
                             }).OrderByDescending(o => o.Total);
            // 2
            var res2 = orders.GroupBy(o => o.Status)
                            .Select(g => new
                            {
                                name = g.Key,
                                count = g.Count(),
                                percentage = ((decimal)g.Count() / (decimal)orders.Count()) * 100
                            });
            // 3
            var res3 = products.Where(p => p.Price >
                            products.Where(o => o.CategoryId == p.Category.Id).Average(p => p.Price)
                            ).Select(p => new
                            {
                                name = p.Name,
                            });
            // 4
            var res4 = orders.Where(o => o.Status == OrderStatus.Cancelled)
                            .SelectMany(i => i.Items)
                            .Select(p => p.Product.Name);

            // 5
            var res5 = customers.Where(c => DateTime.UtcNow.Subtract(c.RegisteredAt).Days >= 30 && c.Orders.Count() >= 1)
                                .Select(c => c.FullName);

            // 6
            var res6 = customers.Select(c => new
            {
                name = c.FullName,
                cancelled = c.Orders.Count(o => o.Status == OrderStatus.Cancelled),

            }).Where(o => o.cancelled > 2);


            // 7
            var res7 = customers.Select(c => new
            {

                name = c.FullName,

                ordercount = c.Orders.Count(o => o.Status == OrderStatus.Delivered),

                totalspent = c.Orders.Where(o => o.Status == OrderStatus.Delivered)
                                     .Sum(o => o.Items.Sum(i => i.Quantity * i.UnitPrice * (1 - i.Discount))),

                averageordervalue = c.Orders.Where(o => o.Status == OrderStatus.Delivered)
                                            .Select(o => o.Items.Sum(i => i.Quantity * i.UnitPrice * (1 - i.Discount)))
                                            .DefaultIfEmpty()
                                            .Average()
            }).OrderByDescending(c => c.totalspent).Take(5);
            // 8
            var res8 = orders.GroupBy(o => o.OrderDate.Month)
                            .Select(g => new
                            {
                                year = 2025,
                                month = g.Key,
                                ordercount = g.Count(),
                                revenue = g.SelectMany(i => i.Items)
                                .Select(i => i.UnitPrice).Sum()
                            });
            // 9
            var res9 = products.GroupBy(c => c.Category.Name)
                                .Select(g => new
                                {
                                    name = g.Key,
                                    revenu = g.Select(p => p.Price).Sum()
                                }).OrderByDescending(p => p.revenu);
            // 10
            var res10 = customers.Where(c => c.Orders.Count() == 0)
                                 .GroupBy(c => c.City)
                                 .Select(g => new
                                 {
                                     no = g.Count()
                                 }).OrderByDescending(c => c.no);
            // 11
            var res11 = products.Where(p => p.Reviews.Count() >= 10 && p.Reviews.Average(r => r.Rating) >= 4.5)
                                .Select(p => new
                                {
                                    name = p.Name,
                                    category = p.Category.Name,
                                    reviewcount = p.Reviews.Count(),
                                    averagerating = p.Reviews.Average(r => r.Rating)
                                });


            // 12
            var res12 = products.GroupBy(c => c.Category.Name)
                                .Select(g => new
                                {
                                    name = g.Key,
                                    toptwo = g.OrderByDescending(p => p.Price).Take(2)
                                    .Select(p => new
                                    {
                                        name = p.Name,
                                        price = p.Price
                                    })
                                });


            // 13
            var res13 = products.Where(p => p.Stock < p.OrderItems.Where(o => o.Order.Status == OrderStatus.Pending).Sum(o => o.Quantity))
                              .Select(p => new
                              {
                                  name = p.Name,
                                  stock = p.Stock,
                                  pendingquantity = p.OrderItems.Where(o => o.Order.Status == OrderStatus.Pending).Sum(o => o.Quantity)
                              });



            // 14
            var spending = customers.Select(c => new
            {
                name = c.FullName,
                customerspeding = c.Orders.Where(o => o.Status == OrderStatus.Delivered).SelectMany(o => o.Items)
                                     .Sum(i => i.Quantity * i.UnitPrice * (1 - i.Discount)),
            }).ToList();
            var averagespending = spending.Average(a => a.customerspeding);
            var res14 = spending.Where(c => c.customerspeding > averagespending);

            // 15
            var res15 = categories.Select(c => new
            {
                name = c.Name,
                bestsell = c.Products.Select(i => new
                {
                    name = i.Name,
                    sell = i.OrderItems.Where(i => i.Order.Status == OrderStatus.Delivered).Sum(i => i.Quantity)
                }).OrderByDescending(p => p.sell).FirstOrDefault()

            });

            // 16
            var bought = customers.Select(c => new
            {
                name = c.FullName,
                id = c.Id,
                boughteveryproduct = c.Orders.SelectMany(i => i.Items)
                                             .Select(p => p.ProductId)
                                               .Distinct()
            });
            var laptopProducts = categories.Where(c => c.Name == "Laptops")
                                  .SelectMany(p => p.Products)
                                  .Select(p => p.Id);
            var res16 = bought.Where(c => laptopProducts.All(id => c.boughteveryproduct.Contains(id)));


            // 17
            var res17 = customers.Join(
                    reviews,
                    x => x.Id,
                    y => y.CustomerId,
                    (x, y) => new { customers = x, reviews = y }
                ).Where(p => !p.customers.Orders.SelectMany(i => i.Items).Any(i => i.ProductId == p.reviews.ProductId))
                .Select(x => new
                {
                    name = x.customers.FullName,
                    comment = x.reviews.Comment,
                });
            // 18
            var res18 = customers.GroupJoin(
                orders,
                x => x.Id,
                y => y.CustomerId,
                (x, customerorders) => new
                {
                    name = x.FullName,
                    ordercount = customerorders.Count()
                }
                );
            // 19
            var res19 = orders.SelectMany(o => o.Items.SelectMany(i1 => o.Items.Where(i2 => i2.ProductId > i1.ProductId).Select(i2 => new {
                Product1Id = i1.ProductId,
                Product1Name = i1.Product.Name,
                Product2Id = i2.ProductId,
                Product2Name = i2.Product.Name
            })
            )
            ).GroupBy(p => new
            {
                p.Product1Id,
                p.Product1Name,
                p.Product2Id,
                p.Product2Name
            })
                .Select(g => new
                {
                    Product1 = g.Key.Product1Name,
                    Product2 = g.Key.Product2Name,
                    TimesTogether = g.Count()
                })
                .OrderByDescending(p => p.TimesTogether)
                .Take(5);

            // 20
            var res20 = customers.Select(c => new
            {
                name = c.FullName,

                order = c.Orders
                .OrderByDescending(o => o.OrderDate)
                .Select(o => new
                {
                    OrderDate = o.OrderDate,
                    Items = o.Items.Select(i => new
                    {
                        ProductName = i.Product.Name,
                        i.Quantity
                    })
                })
                .FirstOrDefault()
                    });
            foreach (var item in res20)
            {
                Console.WriteLine(item);
            }
        }
    }
}
