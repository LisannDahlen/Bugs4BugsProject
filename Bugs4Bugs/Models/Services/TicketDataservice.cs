﻿using Bugs4Bugs.Views.Ticket;
using Microsoft.AspNetCore.Authentication;

namespace Bugs4Bugs.Models.Services
{
    public class TicketDataservice
    {
        ApplicationContext applicationContext;
        public TicketDataservice(ApplicationContext applicationContext)
        {
            applicationContext = applicationContext ?? throw new ArgumentNullException(nameof(applicationContext));
        }

        static List<Product> products = new List<Product>
            {
                new Product()
                {
                   Name = "Visual Studio",
                   PhotoURL = "data:image/jpeg;base64,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"
                },
                 new Product()
                {
                   Name = "Visual Studio Code",
                   PhotoURL = "data:image/jpeg;base64,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"
                },
                 new Product()
                {
                   Name = "Firefox",
                   PhotoURL = "data:image/jpeg;base64,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"
                },
                 new Product()
                {
                   Name = "Chrome",
                   PhotoURL = "data:image/jpeg;base64,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"
                },
                 new Product()
                {
                   Name = "Skynet",
                   PhotoURL = "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAPsAAADJCAMAAADSHrQyAAAAt1BMVEUAAADMzMqDBgZgBAS0BwhnBQR6BQa1BwZGAwIoAACwBgidBwmWBwZbAwNuBAWkBwaPBghXBAQwAwE3AwGqCAiTBgU/AwSIBQZKAAIbGxuNjY0kAQE7BAOgBwe9vbx8AwawsK5MTEyKioqdnZwXFxgLCwu6ubd8fHpGRkQQAABpaWc4ODeCgoAnJydZWVgaAQCmpqUYAQAtAwIvLy5SBAUgAQBycnFhYWLIyMYpKShUVFRHR0g+OzwmDX5AAAAJSUlEQVR4nO2cCXuiMBCGqYiCIOJ9HxWrYrVaj2rb/f+/a8NhTLhERUA77z7bVpMM+ciQTAaUYQAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAgXj7XcfcgNpb9bi3uPsRFmeO2cfchHjRW5jhOLsfdjxhYprLpdDqb/Ytuz0pVAynVjrsrEaOVy6Uj5V3cvYmUZapQqGDEv+T2mixJklK1kMS6EHePIkNblwSCtbBe/xW3Rw7ftVH4I26/q6dzTv7GUldmi2404u7X/dnJnjz7yAsKCuU8KPBx9+6+cIpSV7x46gjvs9PplN0xCmrPu863lcoZus/q9oKSO6c9Jz6peKF2Hv4pt/OlTKrf72fO0U8938ivFRS8VVwCOgfP5/blRlC2T6Z9nTnv7QTPpL4kpXPp4GQrzxPc7zLVC0mV4u5zWHwSybkglJ8ohafJhQtJLePuc2ho/XMBHRXcVZRn2tRoNZ7nA4R1emSHqj7PqBtsU4Fh4+5r2Cxds3Q20vq/6vPdmF7K/WABzpPs4Tsa+apULBa3W/2/K0W9qNjxMfBIcBWZ7Puujrza2/P1oqxEOrzGFuTPqDsdDmW0a6Vyrzvk9H19J+tKRv9BxXMl9NZjhvYdvlPr1OjEc7tW63hjS9eVa4aBB3R71nJlmXxTUAyf99jHi1TSJm/VyjyceBaHadQ1367m9MDNJZZD0ks2A3pVdKIeTbzW4HEygorS2o0GzxOFGL5BebzGW+8iHmtjw1IrOUeV5d2XdZYa3SJpoM89zshrHFqw9CeJjDjNfsmWxJwjkZGl78NqbCWHsx26hf7DLHUlx23Gsn8xgopphIe9T9nIb6m7y3k9nqNq8GQxqpynV3HeeZc6v30It5dzubQVqFlOq4dslNuXRfOSsHw6S9+K4nLO7F4u3X8A8Xn78yQW1ITXUbqi+bCJ/kOkUpNb0d2AzCSdpdB2YdfeCdRKpQltwXi/3RYEakR3gqsFVK+d8JGXRVFCiHYkUaIHrlQ3KnalrkJNc2xXEl0MGHWTHeRwbjFbxYrk6Gu+1rVuO1MOny+4trfIJHip+6x57VVq+r6kQ0V4grFTqVGBrOZpwLSS3AhPVupnoGP7vlJPUQkq9lx7RU6m22uZXNa+NDmgArRGpVIkDXDnb1xl64nM4daCJOPoXMSWCnnKgQwk8JMWWi1Y/p3nvby2E9RA0iY85PA+qTgyC51zD9A0OUBrk1TCZjw++K2HlKvX1oK3r+ejVueH1gl8ywnRcMk8I4cPboBPUg5PDvgojUUlYzfAVS4ykKsn5prPXHKX1Rnhkcm9oAZSCRn5z475xEBwSiVqldbKqHHw9sahEjHfabKk6DsN6aKHSiRi5DmpelF7vaokJSCNZSxudK7iDEb0l8viO818JXdZe6tyPfahX7Ns/gpYFmfgStdZyLMx5/C0rfsHQM6Tx+lL4UoLyEacsb3Wz7nk1oI5Ps5kFCvpwP5O+35WidHt5UvXJgKcv9sWKgXfjIUnhUp8u7rdBcuaA/wo1bJT9vowxQVWokXLmGm06+jieb5Rvd6KJMbyGZvLHxikoX3+euJY6j4vekzUxpqI7D7N11cT+SWvZaqeH/UKAGqMs1X8LYZ0W/1o3X6ZSqfPJ+e8yaaJNS59o62sEukTeWX2Nsi4bn2jLTbSCG9ZZItXhaEkOK5b32wKxbdRuT1y+EvyDO4QPh8s0+dPNaIPG3S8P8p8AThZXQ7FXCSp60+W47hbL1GW5Yh9XP52c3mOu/+Et0zlrtp50NA+f8ssbxgzUgjSvcUb31Ai3RKFmlQlnGjmqyHYQ4j9O0d4OyEscDimhWVxfdeHE5Yp/QmREOiKxF5GDMWkjnK/2d641kMijfcyRu4iJKS7iW83+PDAM1M7RKONO2nfyUHuEQcGr++dUM1m7vEB+nbd+xtKroFa48IzmxbvIL6mf8tgiODYphyu3fC/BnIXRixHwHH4ybJSqIZ12+Fe9EL15lCOIkvGdTft3t2Mdzt+Wi4lX7/g2YILn0C44KmDoDzqp6sAAAAA4GkYvcXdg3Ms9sOWO+qUeVV1Xonq+wHB0GHtTdXf/2CY5mTcGyML9LFWqHD1rf/1tRq4MVa/VR/moZ7O2fjFkw9mZvze49ob9VjW03+oTu0Ds8G38fvlMKO1H/T3Ngwz9TzqYHPw7tDLIEztE58DObXPesc+/Mz8teNz9EVp19v3Nsw/b32D755nWbjaf/1OMtb+YVZ+Pwo6TEaMv/Z/JyMTp/a3lY+6yLSrPsexjzse9NU//ZWf9o8Pwsrcrv2bLLUz/o7K540BOKges92U0P5+HKueeQkH1/5ymhEt7UPDjvsxJ835EKOaFU9vfIWo3ejpyrsca/86jkbrmygZLEYUzdFmfNK+mh/b2LQbkr68jklgzHuDmxR6Y2gffDcRCwvz75FZbl3vm+OgD36OLc2R7fV64xPolXldmNpVPJOq1nCR2tWmO2T33g8h+znJ6qjAwUDdj47a59aKdCBc7t3vsrTGHbkLLZ7U7nrUXo9ywrtqH/oIQEutpd2Sqb6TTf2mSaydmVltV6OT9oVf00Fk2jd+Cwrqx4x4RYcpzGIQRDuzP4pfJE078+G7wP+Q2sc28c2h54kjtDM/1hEGi6RpZ6YrH/Vfe+PXscbql267+PiymGB6du3Mq3WK0CWUMO1IwfR3SvD7amB49MTUPjlG34fW4py1ll5vT2pnplh8k9CuvrpCnd67a3dnTmj/WOAgtDc7067lGHckwTp34x9Ce5D1/b7aF+5n/5UadxTbfOCZbfU6mg3nBMOhGYnNjf/G9fFLa2c2VuvD4aR9fGw/oaDO7Z3nOp9LD03tWDvT/DrObIfWdO7dxHCOxZ7WftzSWqVfXg31UxKd9h9fEb/kXmbTOs55vdnUdxOkMnbtTPO0dRuP/LZqg+i0+477yrZ/n2IBq9+9T87j16mdED9nqLAhmdpXG0feZo99d/hv7rU4oh27Uzvz1rKs6hG7d8okQu2vrlkzHVVXvB/rObSfU/3RBJf/TFXXdnqm40f/q2Xr9GsL7XasVXI69MrXkS02KxczofGmb53wFpRgdCpuUgfHlRdWqds+7M2o4jha8/sUH7yNHDj2cYy7GQAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAC4jv8OPxPPPgOr8gAAAABJRU5ErkJggg=="
                }
            };
        public ChooseProductVM[] GetAllProducts()
        {
            return products.Select(p => new ChooseProductVM { productName = p.Name,
                PhotoURL = p.PhotoURL
            })
                            .ToArray();
        }

        internal CreateTicketVM? GetProductByName(string prodName)
        {
            return products.Where(p => p.Name == prodName)
                .Select(p => new CreateTicketVM
                {
                    ProductName = prodName,
                    BugTypes = p.GetBugtypesArray(),
                    UrgencyLevels = p.GetUrgencyArray(),
                })
                .FirstOrDefault();
        }
        public static List<Ticket> tickets = new List<Ticket> {
            new Ticket
            {
                Id = 1,
                Title = "Mördarrobotar",
                Description = "En smältande polis jagar mig och en Österrikisk bodybuilder säger att jag ska rädda framtiden",
                SubmittedDate = DateTime.Now,
                LastUpdated = DateTime.Now,
                Submitter = new SiteUser{ FirstName = "John", LastName = "Connor", UserName = "JohnConnor" },
                TicketProduct = products.FirstOrDefault(o => o.Name == "Skynet"),
                TicketBugType = products.FirstOrDefault(o => o.Name == "Skynet").bugTypes[0],
                TicketUrgency = products.FirstOrDefault(o => o.Name == "Skynet").urgencies[0],
                TicketStatus = products.FirstOrDefault(o => o.Name == "Skynet").statuses[0]
            },
            new Ticket
            {
                Id = 1,
                Title = "Programmet åt min läxa",
                Description = "Jag gjorde min matteläxa när programmet plötsligt ",
                SubmittedDate = DateTime.Now,
                LastUpdated = DateTime.Now,
                Submitter = new SiteUser{ FirstName = "Tommy", LastName = "Boy", UserName = "TommyBoy97" },
                TicketProduct = products.FirstOrDefault(o => o.Name == "Firefox"),
                TicketBugType = products.FirstOrDefault(o => o.Name == "Firefox").bugTypes[0],
                TicketUrgency = products.FirstOrDefault(o => o.Name == "Firefox").urgencies[0],
                TicketStatus = products.FirstOrDefault(o => o.Name == "Firefox").statuses[0]
            },
        };

        public TicketVM[] GetAllTIckets()
        {
            TicketVM[] ticketVMs = tickets
                .Select(t =>
                new TicketVM {
                    Title = t.Title,
                    Description = t.Description,
                    Submiter = t.Submitter.UserName,
                    Status = t.TicketStatus.TicketStatus,
                    BugType = t.TicketBugType.Type,
                    Urgency = t.TicketUrgency.Level,
                    Submitted = t.SubmittedDate.ToString("dd/MM/yyyy"),
                    LastUpdated = t.LastUpdated.ToString("dd/MM/yyyy"),
                    Developer = t.Developer == null ? "Unassigned" : t.Developer.FirstName + t.Developer.LastName,
                    Product = t.TicketProduct.Name,
                    ProductPhotoURL = t.TicketProduct.PhotoURL
                })
                .ToArray(); 
            return ticketVMs;
        }

    }
}
