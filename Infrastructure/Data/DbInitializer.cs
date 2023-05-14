using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace Infrastructure.Data
{
    public static class DbInitializer
    {
        public static async Task Initialize(DoomContext context)
        {
            context.Database.EnsureCreated();

            // Look for any boards.
            if (context.Boards.Any())
            {
                return; // DB has been seeded
            }

            var boards = new List<Board>
        {
            new Board
            {
                Name = "Smashburgers",
                Description = "All about delicious smashburgers.",
                Type = "Food",
                Fibers = new List<Fiber>
                {
                    new Fiber
                    {
                        Name = "Best Smashburger Recipes",
                        Subject = "Cooking",
                        Comment = "Let's share our best smashburger recipes!",
                        Time = DateTime.Now,
                        Responses = new List<Response>
                        {
                            new Response
                            {
                                Name = "BurgerFan123",
                                Comment = "I love a classic smashburger with American cheese. Simple but tasty.",
                                Time = DateTime.Now
                            },
                            new Response
                            {
                                Name = "GrillMaster",
                                Comment = "Try adding some grilled onions for extra flavor.",
                                Time = DateTime.Now
                            }
                        }
                    },
                    new Fiber
                    {
                        Name = "Perfect Patty Techniques",
                        Subject = "Cooking",
                        Comment = "What's your secret to a perfectly cooked hamburger patty?",
                        Time = DateTime.Now,
                        Responses = new List<Response>
                        {
                            new Response
                            {
                                Name = "SizzlingChef",
                                Comment = "I always make a small indentation in the middle of the patty. It prevents it from puffing up in the center.",
                                Time = DateTime.Now
                            },
                            new Response
                            {
                                Name = "BBQQueen",
                                Comment = "Don't forget to season your patties well. Salt and pepper go a long way!",
                                Time = DateTime.Now
                            }
                        }
                    },
                    new Fiber
                    {
                        Name = "Homemade Burger Sauces",
                        Subject = "Cooking",
                        Comment = "Do you have any favorite homemade sauces to level up your hamburgers?",
                        Time = DateTime.Now,
                        Responses = new List<Response>
                        {
                            new Response
                            {
                                Name = "SauceBoss",
                                Comment = "I like to mix ketchup, mayo, and a bit of relish to make a simple but delicious burger sauce.",
                                Time = DateTime.Now
                            },
                            new Response
                            {
                                Name = "SpiceRider",
                                Comment = "Try adding some chipotle peppers in adobo sauce to mayo for a smoky, spicy kick.",
                                Time = DateTime.Now
                            }
                        }
                    },
                    new Fiber
                    {
                        Name = "Vegetarian Burger Ideas",
                        Subject = "Cooking",
                        Comment = "Any good vegetarian alternatives to the traditional beef patty?",
                        Time = DateTime.Now,
                        Responses = new List<Response>
                        {
                            new Response
                            {
                                Name = "VeggieVibes",
                                Comment = "I love a good black bean burger. Plenty of protein and flavor!",
                                Time = DateTime.Now
                            },
                            new Response
                            {
                                Name = "GreenGriller",
                                Comment = "Portobello mushrooms make a great meat substitute. Marinate them in some balsamic for extra flavor.",
                                Time = DateTime.Now
                            }
                        }
                    },
                    new Fiber
                    {
                        Name = "Best Burger Toppings",
                        Subject = "Cooking",
                        Comment = "What are your go-to toppings to make a burger extra special?",
                        Time = DateTime.Now,
                        Responses = new List<Response>
                        {
                            new Response
                            {
                                Name = "CheesePlease",
                                Comment = "A thick slice of cheddar and some caramelized onions never fail.",
                                Time = DateTime.Now
                            },
                            new Response
                            {
                                Name = "AvocadoLover",
                                Comment = "I like to add some sliced avocado and a spicy mayo. Yum!",
                                Time = DateTime.Now
                            }
                        }
                    }
                }
            },
            new Board
            {
                Name = "Anime",
                Description = "Discussion and sharing of favorite animes.",
                Type = "Entertainment",
                Fibers = new List<Fiber>
                {
                    new Fiber
                    {
                        Name = "Latest Anime Recommendations",
                        Subject = "Recommendations",
                        Comment = "What are some of the latest anime that you'd recommend?",
                        Time = DateTime.Now,
                        Responses = new List<Response>
                        {
                            new Response
                            {
                                Name = "OtakuGuy",
                                Comment = "I'd recommend 'Anime XYZ'. The storyline is fantastic!",
                                Time = DateTime.Now
                            },
                            new Response
                            {
                                Name = "AnimeFan101",
                                Comment = "'Anime ABC' is also great. Animation and character development is top-notch.",
                                Time = DateTime.Now
                            }
                        }
                    },
                    new Fiber
                    {
                        Name = "Berserk Character Analysis",
                        Subject = "Anime",
                        Comment = "Who is your favorite character in Berserk and why?",
                        Time = DateTime.Now,
                        Responses = new List<Response>
                        {
                            new Response
                            {
                                Name = "SwordFan",
                                Comment = "Guts. His character development is profound and his resilience is inspiring.",
                                Time = DateTime.Now
                            },
                            new Response
                            {
                                Name = "GriffithBeliever",
                                Comment = "Griffith. His ambition and transformation are fascinating to analyze.",
                                Time = DateTime.Now
                            }
                        }
                    },
                    new Fiber
                    {
                        Name = "Berserk's Best Arcs",
                        Subject = "Anime",
                        Comment = "What is your favorite story arc from Berserk?",
                        Time = DateTime.Now,
                        Responses = new List<Response>
                        {
                            new Response
                            {
                                Name = "GoldenAgeGuru",
                                Comment = "The Golden Age Arc is unbeatable. The character development and storytelling are superb.",
                                Time = DateTime.Now
                            },
                            new Response
                            {
                                Name = "ConvictionCrusader",
                                Comment = "The Conviction Arc. It's dark, complex, and really deepens the world of Berserk.",
                                Time = DateTime.Now
                            }
                        }
                    },
                    new Fiber
                    {
                        Name = "Understanding Berserk's Themes",
                        Subject = "Anime",
                        Comment = "What themes in Berserk resonate most with you?",
                        Time = DateTime.Now,
                        Responses = new List<Response>
                        {
                            new Response
                            {
                                Name = "PhilosophyOtaku",
                                Comment = "The exploration of human nature and the struggle between fate and free will really stand out to me.",
                                Time = DateTime.Now
                            },
                            new Response
                            {
                                Name = "CausalityCritic",
                                Comment = "I'm interested in the themes of causality and how it impacts the characters' lives.",
                                Time = DateTime.Now
                            }
                        }
                    },
                    new Fiber
                    {
                        Name = "Understanding Berserk's Themes",
                        Subject = "Anime",
                        Comment = "What themes in Berserk resonate most with you?",
                        Time = DateTime.Now,
                        Responses = new List<Response>
                        {
                            new Response
                            {
                                Name = "PhilosophyOtaku",
                                Comment = "The exploration of human nature and the struggle between fate and free will really stand out to me.",
                                Time = DateTime.Now
                            },
                            new Response
                            {
                                Name = "CausalityCritic",
                                Comment = "I'm interested in the themes of causality and how it impacts the characters' lives.",
                                Time = DateTime.Now
                            }
                        }
                    },
                    new Fiber
                    {
                        Name = "Berserk's Artwork Discussion",
                        Subject = "Anime",
                        Comment = "Let's talk about the artwork of Berserk. What are your thoughts?",
                        Time = DateTime.Now,
                        Responses = new List<Response>
                        {
                            new Response
                            {
                                Name = "MangaMaster",
                                Comment = "Kentaro Miura's attention to detail is amazing. The intricate artwork really brings the world of Berserk to life.",
                                Time = DateTime.Now
                            },
                            new Response
                            {
                                Name = "ArtAficionado",
                                Comment = "I love the contrasting use of light and shadow. It adds to the series' intense atmosphere.",
                                Time = DateTime.Now
                            }
                        }
                    }
                }
            }
        };

            await context.Boards.AddRangeAsync(boards);
            await context.SaveChangesAsync();
        }
    }

}