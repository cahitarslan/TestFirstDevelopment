using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Demo.Tests
{
    [TestClass]
    public class GruplayiciTests
    {
        private List<Olcum> OlcumListesiOlustur(int adet)
        {
            var olcumler = new List<Olcum>();

            for (int i = 0; i < adet; i++)
            {
                olcumler.Add(new Olcum
                {
                    EnYuksek = 10,
                    EnDusuk = 1
                });
            }
            return olcumler;
        }



        [TestMethod]
        public void bir_elemanlı_liste_birerli_gruplanmak_istendiğinde_grup_sayısı_bir_olmalıdır()
        {
            var olcumler = new List<Olcum>
            {
                new Olcum
                {
                    EnYuksek = 10,
                    EnDusuk = 1
                }
            };

            var gruplayici = new Gruplayici(1);
            var gruplar = gruplayici.Grupla(olcumler);

            Assert.AreEqual(1, gruplar.Count);
        }

        [TestMethod]
        public void altı_elemanlı_liste_ikişerli_gruplanmak_istendiğinde_grup_sayısı_üç_olmalıdır()
        {
            var olcumler = new List<Olcum>
            {
                new Olcum
                {
                    EnYuksek = 10,
                    EnDusuk = 1
                },
                new Olcum
                {
                    EnYuksek = 10,
                    EnDusuk = 1
                },
                new Olcum
                {
                    EnYuksek = 10,
                    EnDusuk = 1
                },
                new Olcum
                {
                    EnYuksek = 10,
                    EnDusuk = 1
                },
                new Olcum
                {
                    EnYuksek = 10,
                    EnDusuk = 1
                },
                new Olcum
                {
                    EnYuksek = 10,
                    EnDusuk = 1
                }
            };

            var gruplayici = new Gruplayici(2);
            var gruplar = gruplayici.Grupla(olcumler);

            Assert.AreEqual(3, gruplar.Count);
        }

        [TestMethod]
        public void elli_elemanlı_liste_onarlı_gruplanmak_istendiğinde_grup_sayısı_beş_olmalıdır()
        {
            var olcumler = OlcumListesiOlustur(50); 

            var gruplayici = new Gruplayici(10);
            var gruplar = gruplayici.Grupla(olcumler);

            Assert.AreEqual(5, gruplar.Count);
        }
    }
}
