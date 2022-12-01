using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calidad20222.web.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calidad20222.web.Models;

namespace Calidad20222.web.Services.Tests
{
    [TestClass()]
    public class PokerServiceTests
    {
        [TestMethod()]    
        public void GetJugadaTest_01()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                   new Carta()
                   {
                       Numero = 10, Palo = "COCOS"
                   },
                   new Carta()
                   {
                        Numero = 9, Palo = "COCOS"
                   },
                   new Carta()
                   {
                        Numero = 8, Palo = "COCOS"
                   },
                   new Carta()
                   {
                        Numero = 7, Palo = "COCOS"
                   },
                   new Carta()
                   {
                        Numero = 6, Palo = "COCOS"
                   },

            };
            Assert.AreNotEqual("ESCALERA", cartaList);
        }
        [TestMethod()]
        public void GetJugadaTest_02()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                   new Carta()
                   {
                       Numero = 10, Palo = "CORAZONES"
                   },
                   new Carta()
                   {
                        Numero = 8, Palo = "CORAZONES"
                   },
                   new Carta()
                   {
                        Numero = 6, Palo = "CORAZONES"
                   },
                   new Carta()
                   {
                        Numero = 4, Palo = "CORAZONES"
                   },
                   new Carta()
                   {
                        Numero = 2, Palo = "CORAZONES"
                   },

            };
            Assert.AreNotEqual("ESCALERA", cartaList);

        }
        [TestMethod()]
        public void GetJugadaTest_03()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                   new Carta()
                   {
                       Numero = 1, Palo = "ESPADA"
                   },
                   new Carta()
                   {
                        Numero = 5, Palo = "ESPADA"
                   },
                   new Carta()
                   {
                        Numero = 3, Palo = "ESPADA"
                   },
                   new Carta()
                   {
                        Numero = 8, Palo = "ESPADA"
                   },
                   new Carta()
                   {
                        Numero = 11, Palo = "ESPADA"
                   },

            };
            Assert.AreNotEqual("COLOR", cartaList);

        }
        [TestMethod()]
        public void GetJugadaTest_04()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                   new Carta()
                   {
                       Numero = 12, Palo = "CORAZONES"
                   },
                   new Carta()
                   {
                        Numero = 7, Palo = "COCOS"
                   },
                   new Carta()
                   {
                        Numero = 12, Palo = "TREBOL"
                   },
                   new Carta()
                   {
                        Numero = 7, Palo = "TREBOL"
                   },
                   new Carta()
                   {
                        Numero = 6, Palo = "ESPADA"
                   },

            };
            Assert.AreNotEqual("DOBLE PAREJA", cartaList);

        }
        [TestMethod()]
        public void GetJugadaTest_05()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                   new Carta()
                   {
                       Numero = 5, Palo = "COCOS"
                   },
                   new Carta()
                   {
                        Numero = 1, Palo = "COCOS"
                   },
                   new Carta()
                   {
                        Numero = 1, Palo = "ESPADA"
                   },
                   new Carta()
                   {
                        Numero = 1, Palo = "TREBOL"
                   },
                   new Carta()
                   {
                        Numero = 5, Palo = "CORAZONES"
                   },

            };
            Assert.AreNotEqual("FULL", cartaList);

        }
        [TestMethod()]
        public void GetJugadaTest_06()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                   new Carta()
                   {
                       Numero = 1, Palo = "TREBOL"
                   },
                   new Carta()
                   {
                        Numero = 6, Palo = "ESPADA"
                   },
                   new Carta()
                   {
                        Numero = 6, Palo = "COCOS"
                   },
                   new Carta()
                   {
                        Numero = 13, Palo = "TREBOL"
                   },
                   new Carta()
                   {
                        Numero = 6, Palo = "CORAZONES"
                   },

            };
            Assert.AreNotEqual("TRIO", cartaList);

        }
        [TestMethod()]
        public void GetJugadaTest_07()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                   new Carta()
                   {
                       Numero = 5, Palo = "TREBOL"
                   },
                   new Carta()
                   {
                        Numero = 4, Palo = "TREBOL"
                   },
                   new Carta()
                   {
                        Numero = 3, Palo = "TREBOL"
                   },
                   new Carta()
                   {
                        Numero = 2, Palo = "TREBOL"
                   },
                   new Carta()
                   {
                        Numero = 1, Palo = "TREBOL"
                   },

            };
            Assert.AreNotEqual("ESCALERA", cartaList);

        }
        [TestMethod()]
        virtual public void GetJugadaTest_08()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                   new Carta()
                   {
                       Numero = 12, Palo = "CORAZONES"
                   },
                   new Carta()
                   {
                        Numero = 9, Palo = "TREBOL"
                   },
                   new Carta()
                   {
                        Numero = 8, Palo = "DOBLE"
                   },
                   new Carta()
                   {
                        Numero = 8, Palo = "DOBLE"
                   },
                   new Carta()
                   {
                        Numero = 6, Palo = "COCOS"
                   },

            };
            Assert.AreNotEqual("DOBLE", cartaList);

        }
        [TestMethod()]
        public void GetJugadaTest_09()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                   new Carta()
                   {
                       Numero = 1, Palo = "ESPADA"
                   },
                   new Carta()
                   {
                        Numero = 13, Palo = "ESPADA"
                   },
                   new Carta()
                   {
                        Numero = 12, Palo = "ESPADA"
                   },
                   new Carta()
                   {
                        Numero = 10, Palo = "ESPADA"
                   },
                   new Carta()
                   {
                        Numero = 8, Palo = "ESPADA"
                   },

            };
            Assert.AreNotEqual("COLOR", cartaList);

        }
        [TestMethod()]
        public void GetJugadaTest_10()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                   new Carta()
                   {
                       Numero = 7, Palo = "COCOS"
                   },
                   new Carta()
                   {
                        Numero = 9, Palo = "ESPADA"
                   },
                   new Carta()
                   {
                        Numero = 8, Palo = "CORAZONES"
                   },
                   new Carta()
                   {
                        Numero = 13, Palo = "TREBOL"
                   },
                   new Carta()
                   {
                        Numero = 9, Palo = "COCOS"
                   },

            };
            Assert.AreNotEqual("DOBLE", cartaList);

        }
        [TestMethod()]
        public void GetJugadaTest_11()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                   new Carta()
                   {
                       Numero = 12, Palo = "ESPADA"
                   },
                   new Carta()
                   {
                        Numero = 9, Palo = "COCOS"
                   },
                   new Carta()
                   {
                        Numero = 12, Palo = "TREBOL"
                   },
                   new Carta()
                   {
                        Numero = 12, Palo = "COCOS"
                   },
                   new Carta()
                   {
                        Numero = 12, Palo = "CORAZONES"
                   },

            };
            Assert.AreNotEqual("POKER", cartaList);

        }
        [TestMethod()]
        public void GetJugadaTest_12()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                   new Carta()
                   {
                       Numero = 11, Palo = "ESPADA"
                   },
                   new Carta()
                   {
                        Numero = 3, Palo = "COCOS"
                   },
                   new Carta()
                   {
                        Numero = 5, Palo = "CORAZONES"
                   },
                   new Carta()
                   {
                        Numero = 11, Palo = "COCOS"
                   },
                   new Carta()
                   {
                        Numero = 3, Palo = "CORAZONES"
                   },

            };
            Assert.AreNotEqual("DOBLE PAREJA", cartaList);

        }
        [TestMethod()]
        public void GetJugadaTest_13()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                   new Carta()
                   {
                       Numero = 2, Palo = "ESPADA"
                   },
                   new Carta()
                   {
                        Numero = 7, Palo = "COCOS"
                   },
                   new Carta()
                   {
                        Numero = 7, Palo = "CORAZONES"
                   },
                   new Carta()
                   {
                        Numero = 2, Palo = "TREBOL"
                   },
                   new Carta()
                   {
                        Numero = 4, Palo = "COCOS"
                   },

            };
            Assert.AreNotEqual("DOBLE PAREJA", cartaList);

        }
        [TestMethod()]
        public void GetJugadaTest_14()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                   new Carta()
                   {
                       Numero = 1, Palo = "COCOS"
                   },
                   new Carta()
                   {
                        Numero = 13, Palo = "COCOS"
                   },
                   new Carta()
                   {
                        Numero = 12, Palo = "COCOS"
                   },
                   new Carta()
                   {
                        Numero = 11, Palo = "COCOS"
                   },
                   new Carta()
                   {
                        Numero = 10, Palo = "COCOS"
                   },

            };
            Assert.AreNotEqual("ESCALERA", cartaList);

        }
        [TestMethod()]
        public void GetJugadaTest_15()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                   new Carta()
                   {
                       Numero = 10, Palo = "COCOS"
                   },
                   new Carta()
                   {
                        Numero = 9, Palo = "CORAZONES"
                   },
                   new Carta()
                   {
                        Numero = 5, Palo = "COCOS"
                   },
                   new Carta()
                   {
                        Numero = 5, Palo = "TREBOL"
                   },
                   new Carta()
                   {
                        Numero = 5, Palo = "CORAZONES"
                   },

            };
            Assert.AreNotEqual("TRIO", cartaList);

        }
        [TestMethod()]
        public void GetJugadaTest_16()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                   new Carta()
                   {
                       Numero = 13, Palo = "ESAPADA"
                   },
                   new Carta()
                   {
                        Numero = 13, Palo = "TREBOL"
                   },
                   new Carta()
                   {
                        Numero = 13, Palo = "CORAZONES"
                   },
                   new Carta()
                   {
                        Numero = 13, Palo = "COCOS"
                   },
                   new Carta()
                   {
                        Numero = 1, Palo = "COCOS"
                   },

            };
            Assert.AreNotEqual("POKER", cartaList);

        }
        [TestMethod()]
        public void GetJugadaTest_17()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                   new Carta()
                   {
                       Numero = 12, Palo = "ESPADA"
                   },
                   new Carta()
                   {
                        Numero = 3, Palo = "CORAZONES"
                   },
                   new Carta()
                   {
                        Numero = 3, Palo = "TREBOL"
                   },
                   new Carta()
                   {
                        Numero = 3, Palo = "COCOS"
                   },
                   new Carta()
                   {
                        Numero = 6, Palo = "TREBOL"
                   },

            };
            Assert.AreNotEqual("TRIO", cartaList);

        }
        [TestMethod()]
        public void GetJugadaTest_18()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                   new Carta()
                   {
                       Numero = 10, Palo = "ESPADA"
                   },
                   new Carta()
                   {
                        Numero = 13, Palo = "COCOS"
                   },
                   new Carta()
                   {
                        Numero = 9, Palo = "CORAZONES"
                   },
                   new Carta()
                   {
                        Numero = 2, Palo = "TREBOL"
                   },
                   new Carta()
                   {
                        Numero = 12, Palo = "TREBOL"
                   },

            };
            Assert.AreNotEqual("CARTA ALTA", cartaList);

        }
        [TestMethod()]
        public void GetJugadaTest_19()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                   new Carta()
                   {
                       Numero = 10, Palo = "CORAZONES"
                   },
                   new Carta()
                   {
                        Numero = 10, Palo = "COCOS"
                   },
                   new Carta()
                   {
                        Numero = 2, Palo = "CORAZONES"
                   },
                   new Carta()
                   {
                        Numero = 2, Palo = "TREBOL"
                   },
                   new Carta()
                   {
                        Numero = 7, Palo = "COCOS"
                   },

            };
            Assert.AreNotEqual("DOBLE PAREJA", cartaList);

        }
        [TestMethod()]
        public void GetJugadaTest_20()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                   new Carta()
                   {
                       Numero = 7, Palo = "ESPADA"
                   },
                   new Carta()
                   {
                        Numero = 4, Palo = "CORAZONES"
                   },
                   new Carta()
                   {
                        Numero = 10, Palo = "COCOS"
                   },
                   new Carta()
                   {
                        Numero = 2, Palo = "TREBOL"
                   },
                   new Carta()
                   {
                        Numero = 12, Palo = "TREBOL"
                   },

            };
            Assert.AreNotEqual("CARTA ALTA", cartaList);

        }
    }
}