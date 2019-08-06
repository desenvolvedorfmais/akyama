using System;
using System.Collections.Generic;
using System.Linq;
using Bogus;
using Matching_cs.Model;

namespace Matching_cs.Helper
{
    public static class FakerHelper
    {
        private static tbBiometria_Akiama biometriaFirst;
        private static IQueryable<tbBiometria_Akiama> biometriaList;

        public static IEnumerable<tbBiometria_Akiama> ByteBiometriListFaker()
        {

            byte[] byteJsonFirstBytes, lastBytes = new byte[] { };

          
            
            try
            {
                using (var ctx = new FMContext())
                {
                   biometriaList =  ctx.tbBiometria_Akiama;
                   ctx.Dispose();
                }

                var biometria = biometriaList.FirstOrDefault();


                //biometriaList.ForEach(b => templates.Add(new Template(new MemoryStream(b.biometriaBytes))));

                //byteJsonFirstBytes = biometria.FirstOrDefault().biometriaBytes;
                //lastBytes = biometria.LastOrDefault().biometriaBytes;


                //template.DeSerialize(byteJsonFirstBytes);
                ////Data.Templates[0]= template;

                //var templateBiometriaFirstFaker = new Faker<Template>()
                //      .CustomInstantiator(f => template);

                // template = new Template();
                //template.DeSerialize(lastBytes);
                //var templateBiometriaLastFaker = new Faker<Template>()
                //    .CustomInstantiator(f => template);


                var bometriaFaker = new Faker<tbBiometria_Akiama>()
                    .RuleFor(t => t.biometriaBytes, f => biometria.biometriaBytes);




                SaveList(bometriaFaker .Generate(7000).ToList());

                //var restultLast = templateBiometriaLastFaker.Generate(1);

                //restult = restult.Concat(restultLast).ToList();

                return biometriaList;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);

            }

            return null;
        }


        public static List<tbBiometria_Akiama> TemplateBimetriaFaker(int countSkip = 0, int countTake = 0, bool isSkip = false)
        {

            byte[] byteJsonFirstBytes, lastBytes = new byte[] { };

            var biometriaList = new List<tbBiometria_Akiama>();
           
            try
            {
                using (var ctx = new FMContext())
                {

                    if(isSkip)
                    biometriaList = ctx.tbBiometria_Akiama.Skip(countSkip).Take(countTake).ToList();
                    else
                        biometriaList = ctx.tbBiometria_Akiama.Take(8000).ToList();

                }


                if (false)
                {
                    var tempbiometriaListFaker = new List<tbBiometria_Akiama>();
                   
                    foreach (var biometria in biometriaList)
                    {
                        
                        tempbiometriaListFaker.Add(biometria);
                    }

                    for (int i = 0; i < 15000; i++)
                    {
                        var biometria = new tbBiometria_Akiama
                        {
                            biometriaBytes = tempbiometriaListFaker[i].biometriaBytes
                        };

                        tempbiometriaListFaker.Add(biometria);
                    }


                    
                    SaveList(tempbiometriaListFaker);
                }
                 
                //var last = biometriaList.LastOrDefault(x => x.id.Equals(2));

                return biometriaList;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);

            }

            return null;
        }

        public static IEnumerable<tbBiometria_Akiama> FacktoryBiometriaList(IEnumerable<tbBiometria_Akiama> biometriaList, int countSkip, int countTake, bool skip)
        {
            return biometriaList.Skip(countSkip).Take(countTake);
        }

        public static IEnumerable<tbBiometria_Akiama> FacktoryBiometriaList( int countSkip, int countTake, bool skip)
        {
            IEnumerable<tbBiometria_Akiama> biometriaList;
            using (var ctx = new FMContext())
            {
                biometriaList = ctx.tbBiometria_Akiama.Skip(countSkip).Take(countTake).ToList();
                ctx.Dispose();
                
            }

            return biometriaList;
        }

        //public static IEnumerable<tbBiometria_Akiama> FacktoryBiometriaList(int whereId = 0,  int countSkip = 0, int countTake = 0, bool skip = false)
        //{
        //    IEnumerable<tbBiometria_Akiama> biometriaList;
        //    using (var ctx = new FMContext())
        //    {
        //        if(whereId > 0 )
        //        biometriaList = ctx.tbBiometria_Akiama.Find(whereId);


        //        ctx.Dispose();

        //    }

        //    return biometriaList;
        //}


        public static tbBiometria_Akiama FacktoryBiometriaList(int whereId = 0, int countSkip = 0, int countTake = 0, bool skip = false)
        {
            
            using (var ctx = new FMContext())
            {
                if (whereId > 0)
                    biometriaFirst = ctx.tbBiometria_Akiama.Find(whereId);


                ctx.Dispose();

            }

            return biometriaFirst;
        }



        public static void SaveList(IEnumerable<tbBiometria_Akiama> biometriaList = null, int totalFaker = 1000 , bool faker = false, bool saveFaker = false)
        {
            try
            {
                if (!saveFaker)
                    return;

                var biometria = biometriaList.FirstOrDefault();

                if (faker)
                {
                    var bometriaFaker = new Faker<tbBiometria_Akiama>()
                   .RuleFor(t => t.biometriaBytes, f => biometria.biometriaBytes);

                    biometriaList = bometriaFaker.Generate(totalFaker).ToList();
                }


                using (var ctx = new FMContext())
                {
                    ctx.tbBiometria_Akiama.AddRange(biometriaList);
                    ctx.SaveChanges();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                
            }
          
        }

        public static T[] Concat<T>(this T[] x, T[] y)
        {
            if (x == null) throw new ArgumentNullException("x");
            if (y == null) throw new ArgumentNullException("y");
            int oldLen = x.Length;
            Array.Resize<T>(ref x, x.Length + y.Length);
            Array.Copy(y, 0, x, oldLen, y.Length);
            return x;
        }

       
    }
}
