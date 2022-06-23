using System;

namespace Tugas_Akhir_Project_3_Final
{
    class TeaTime
    {
        static void BannerJudul()
        {
            //Mencetak Judul Aplikasi
            string title = @"
 ________  ________   ______   ________  ______  __       __  ________ 
/        |/        | /      \ /        |/      |/  \     /  |/        |
$$$$$$$$/ $$$$$$$$/ /$$$$$$  |$$$$$$$$/ $$$$$$/ $$  \   /$$ |$$$$$$$$/ 
   $$ |   $$ |__    $$ |__$$ |   $$ |     $$ |  $$$  \ /$$$ |$$ |__    
   $$ |   $$    |   $$    $$ |   $$ |     $$ |  $$$$  /$$$$ |$$    |   
   $$ |   $$$$$/    $$$$$$$$ |   $$ |     $$ |  $$ $$ $$/$$ |$$$$$/    
   $$ |   $$ |_____ $$ |  $$ |   $$ |    _$$ |_ $$ |$$$/ $$ |$$ |_____ 
   $$ |   $$       |$$ |  $$ |   $$ |   / $$   |$$ | $/  $$ |$$       |
   $$/    $$$$$$$$/ $$/   $$/    $$/    $$$$$$/ $$/      $$/ $$$$$$$$/ 
                                                                       
   
";
            Console.WriteLine(title);
        }
        static void DaftarFitur()
        {
            Console.WriteLine("\t\tProgram berikut memiliki 4 FITUR UTAMA");
            Console.WriteLine("\t\t   Menampilkan daftar menu");
            Console.WriteLine("\t\t1. Lakukan transaksi\n\t\t2. Memiliki fitur ganti harga menu minuman");
            Console.WriteLine("\t\t3. Memiliki fitur ganti harga topping\n\t\t4. RESET HARGA\n\n");
        }
        static string[] pilihMenu = { "Bronze Sugar Milk Tea      ", "Mango Green Tea            ", "Taro Milk Tea              ", "Hazelnut Chocolate Milk Tea", "Strawberry Milk Tea        " };
        static int[] hargaMenu = { 4000, 6000, 5000, 7000, 9000 };
        static string[] pilihTopping = { "Pearl", "Pudding", "RedBean", "Jelly" };
        static int[] hargaTopping = { 1500, 4000, 2500, 3000 };
        static string[] pilihGelas = { "REGULER", "LARGE" };
        static int[] hargaGelas = { 0, 5000 };
        static string[] takaranGula = { "None", "Slight", "Half", "Less", "Normal", "EXTRA" };
        static int[] hargaGula = { 0, 0, 0, 0, 0, 2000 };
        static string[] takaranIce = { "NO   Ice", "REGULAR Ice", "EXTRA Ice" };
        static int[] hargaIce = { 0, 0, 1000 };

        static int kuantitasPesanan = 0;
        static int pesanan;
        static int totalHarga = 0;

        static void DaftarMenuTersedia()
        {
            //List Menu dan Topping yang tersedia
            Console.WriteLine("=========================\t\t\t============================");
            Console.WriteLine("DAFTAR MENU YANG TERSEDIA\t  HARGA\t\tDAFTAR TOPPING YANG TERSEDIA\t  HARGA");
            Console.WriteLine("=========================\t\t\t============================");
            Console.WriteLine("1. Brown Sugar Milk Tea          Rp {0}  \t1. Pearl  \t\t\tRp {1}", hargaMenu[0], hargaTopping[0]);
            Console.WriteLine("2. Mango Green Tea               Rp {0}  \t2. Pudding    \t\t\tRp {1}", hargaMenu[1], hargaTopping[1]);
            Console.WriteLine("3. Taro Milk Tea                 Rp {0}  \t3. Red bean   \t\t\tRp {1}", hargaMenu[2], hargaTopping[2]);
            Console.WriteLine("4. Hazelnut Chocolate Milk Tea   Rp {0}  \t4. Jelly  \t\t\tRp {1}", hargaMenu[3], hargaTopping[3]);
            Console.WriteLine("5. Strawberry Milk Tea           Rp {0}  ", hargaMenu[4] + Environment.NewLine);
        }
        static void DaftarMinumanTersedia()
        {
            //List Menu dan Topping yang tersedia
            Console.WriteLine("==========================================");
            Console.WriteLine("DAFTAR MENU TERSEDIA\t\t    HARGA");
            Console.WriteLine("==========================================");
            Console.WriteLine("1. Brown Sugar Milk Tea          Rp {0},00", hargaMenu[0]);
            Console.WriteLine("2. Mango Green Tea               Rp {0},00", hargaMenu[1]);
            Console.WriteLine("3. Taro Milk Tea                 Rp {0},00", hargaMenu[2]);
            Console.WriteLine("4. Hazelnut Chocolate Milk Tea   Rp {0},00", hargaMenu[3]);
            Console.WriteLine("5. Strawberry Milk Tea           Rp {0},00\n", hargaMenu[4]);
        }

        static void DaftarToppingTersedia()
        {
            //List Menu dan Topping yang tersedia
            Console.WriteLine("==========================================");
            Console.WriteLine("DAFTAR TOPPING TERSEDIA\t\t   HARGA");
            Console.WriteLine("==========================================");
            Console.WriteLine("1. Pearl  \t\t\tRp {0},00", hargaTopping[0]);
            Console.WriteLine("2. Pudding    \t\t\tRp {0},00", hargaTopping[1]);
            Console.WriteLine("3. Red bean   \t\t\tRp {0},00", hargaTopping[2]);
            Console.WriteLine("4. Jelly  \t\t\tRp {0},00\n", hargaTopping[3]);
        }

        static void LanjutTransaksi()
        {
            Console.Write("LANJUTKAN TRANSAKSI (y)? ");
            char lanjut = Convert.ToChar(Console.ReadLine());
            switch (lanjut)
            {
                case 'y':
                    {
                        Console.Clear();
                        Transaksi();
                        break;
                    }
                default:
                    {
                        Console.Clear();
                        Main();
                        break;
                    }
            }
        }
        static string customer;
        static void Customer()
        {
            //Menampilkan nama customer
            Console.Write("Pesanan atas nama saudara/i : ");
            customer = Console.ReadLine();
        }

        static int menu;
        static string menuDipilih;
        static int topping;
        static string toppingDipilih;
        static int gelas;
        static string gelasDipilih;
        static int gula;
        static string gulaDipilih;
        static int ice;
        static string iceDipilih;

        static void Transaksi()
        {
        MulaiTransaksi:
            Console.WriteLine("\n=========DAFTAR MENU YANG TERSEDIA=========");
            Console.WriteLine("1. Brown Sugar Milk Tea          Rp {0},00", hargaMenu[0]);
            Console.WriteLine("2. Mango Green Tea               Rp {0},00", hargaMenu[1]);
            Console.WriteLine("3. Taro Milk Tea                 Rp {0},00", hargaMenu[2]);
            Console.WriteLine("4. Hazelnut Chocolate Milk Tea   Rp {0},00", hargaMenu[3]);
            Console.WriteLine("5. Strawberry Milk Tea           Rp {0},00", hargaMenu[4]);
            InputMenu:
            Console.Write("\nKetik pilihan (1),(2),(3),(4),(5) menu minumanan: ");
            int opsiMenu = Convert.ToInt32(Console.ReadLine());
            switch (opsiMenu)
            {
                case (1):
                    {
                        Console.WriteLine("Harga Rp {0},00 untuk minuman {1}", hargaMenu[0],pilihMenu[0]);
                        menu = hargaMenu[0];
                        menuDipilih = pilihMenu[0];
                        break;
                    }
                case (2):
                    {
                        Console.WriteLine("Harga Rp {0},00 untuk minuman {1}", hargaMenu[1], pilihMenu[1]);
                        menu = hargaMenu[1];
                        menuDipilih = pilihMenu[1];
                        break;
                    }
                case (3):
                    {
                        Console.WriteLine("Harga Rp {0},00 untuk minuman {1}", hargaMenu[2], pilihMenu[2]);
                        menu = hargaMenu[2];
                        menuDipilih = pilihMenu[2];
                        break;
                    }
                case (4):
                    {
                        Console.WriteLine("Harga Rp {0},00 untuk minuman {1}", hargaMenu[3], pilihMenu[3]);
                        menu = hargaMenu[3];
                        menuDipilih = pilihMenu[3];
                        break;
                    }
                case (5):
                    {
                        Console.WriteLine("Harga Rp {0},00 untuk minuman {1}", hargaMenu[4], pilihMenu[4]);
                        menu = hargaMenu[4];
                        menuDipilih = pilihMenu[4];
                        break;
                    }
                default:
                    {
                        goto InputMenu;
                    }
            }


            Console.WriteLine("\n\n=====DAFTAR TOPPING YANG TERSEDIA=====");
            Console.WriteLine("1. Pearl     \t\t\tRp {0},00", hargaTopping[0]);
            Console.WriteLine("2. Pudding   \t\t\tRp {0},00", hargaTopping[1]);
            Console.WriteLine("3. RedBean   \t\t\tRp {0},00", hargaTopping[2]);
            Console.WriteLine("4. Jelly     \t\t\tRp {0},00", hargaTopping[3]);
            InputTopping:
            Console.Write("\nKetik pilihan (1),(2),(3),(4) menu topping: ");
            int opsiTopping = Convert.ToInt32(Console.ReadLine());
            switch (opsiTopping)
            {
                case (1):
                    {
                        Console.WriteLine("Topping pilihan Anda adalah {0} dengan harga Rp {1},00", pilihTopping[0], hargaTopping[0]);
                        topping = hargaTopping[0];
                        toppingDipilih = pilihTopping[0];
                        break;
                    }
                case (2):
                    {
                        Console.WriteLine("Topping pilihan Anda adalah {0} dengan harga Rp {1},00", pilihTopping[1], hargaTopping[1]);
                        topping = hargaTopping[1];
                        toppingDipilih = pilihTopping[1];
                        break;
                    }
                case (3):
                    {
                        Console.WriteLine("Topping pilihan Anda adalah {0} dengan harga Rp {1},00", pilihTopping[2], hargaTopping[2]);
                        topping = hargaTopping[2];
                        toppingDipilih = pilihTopping[2];
                        break;
                    }
                case (4):
                    {
                        Console.WriteLine("Topping pilihan Anda adalah {0} dengan harga Rp {1},00", pilihTopping[3], hargaTopping[3]);
                        topping = hargaTopping[3];
                        toppingDipilih = pilihTopping[3];
                        break;
                    }
                default:
                    {
                        goto InputTopping;
                    }
            }

            Console.WriteLine("\n\n=======UKURAN GELAS TERSEDIA=======");
            Console.WriteLine("1. REGULER\t       Rp    {0},00\n2. LARGE\t       Rp {1},00", hargaGelas[0], hargaGelas[1]);
            InputGelas:
            Console.Write("\nKetik pilihan (1),(2) gelas: ");
            int opsiGelas = Convert.ToInt32(Console.ReadLine());
            switch (opsiGelas)
            {
                case (1):
                    {
                        Console.WriteLine("Pesanan Anda dengan gelas {0} tanpa biaya tambahan Rp {1},00", pilihGelas[0], hargaGelas[0]);
                        gelas = hargaGelas[0];
                        gelasDipilih = pilihGelas[0];
                        break;
                    }
                case (2):
                    {
                        Console.WriteLine("Dikenakan biaya tambahan untuk gelas {0} sebesar Rp {1},00", pilihGelas[1], hargaGelas[1]);
                        gelas = hargaGelas[1];
                        gelasDipilih = pilihGelas[1];
                        break;
                    }
                default:
                    {
                        goto InputGelas;
                    }
            }


            Console.WriteLine("\n\n=======TAMBAHAN GULA YANG TERSEDIA=======");
            Console.WriteLine("1. None    \t\t\t4. Less\n2. Slight\t\t\t5. Normal\n3. Half    \t\t\t6. EXTRA\t  Rp {0},00", hargaGula[5]);
            InputGula:
            Console.Write("\nKetik pilihan (1),(2),(3),(4),(5),(6) gula:  ");
            int opsiGula = Convert.ToInt32(Console.ReadLine());
            switch (opsiGula)
            {
                case (1):
                    {
                        Console.WriteLine("Pesanan Anda dengan gula {0} tanpa biaya tambahan Rp {1},00", takaranGula[0], hargaGula[0]);
                        gula = hargaGula[0];
                        gulaDipilih = takaranGula[0];
                        break;
                    }
                case (2):
                    {
                        Console.WriteLine("Pesanan Anda dengan gula {0} tanpa biaya tambahan Rp {1},00", takaranGula[1], hargaGula[1]);
                        gula = hargaGula[1];
                        gulaDipilih = takaranGula[1];
                        break;
                    }
                case (3):
                    {
                        Console.WriteLine("Pesanan Anda dengan gula {0} tanpa biaya tambahan Rp {1},00", takaranGula[2], hargaGula[2]);
                        gula = hargaGula[2];
                        gulaDipilih = takaranGula[2];
                        break;
                    }
                case (4):
                    {
                        Console.WriteLine("Pesanan Anda dengan gula {0} tanpa biaya tambahan Rp {1},00", takaranGula[3], hargaGula[3]);
                        gula = hargaGula[3];
                        gulaDipilih = takaranGula[3];
                        break;
                    }
                case (5):
                    {
                        Console.WriteLine("Pesanan Anda dengan gula {0} tanpa biaya tambahan Rp {1},00", takaranGula[4], hargaGula[4]);
                        gula = hargaGula[4];
                        gulaDipilih = takaranGula[4];
                        break;
                    }
                case (6):
                    {
                        Console.WriteLine("Dikenakan biaya tambahan untuk {0} gula sebesar Rp {1},00", takaranGula[5], hargaGula[5]);
                        gula = hargaGula[5];
                        gulaDipilih = takaranGula[5];
                        break;
                    }
                default:
                    {
                        goto InputGula;
                    }
            }


            Console.WriteLine("\n\n=====TAMBAHAN ES YANG TERSEDIA=====");
            Console.WriteLine("1. No Ice\t\tRp {0},00\n2. REGULAR Ice\t\tRp {1},00\n3. EXTRA Ice\t\tRp {2},00", hargaIce[0], hargaIce[1], hargaIce[2]);
            InputIce:
            Console.Write("\nKetik pilihan (1),(2),(3) es: ");
            int opsiIce = Convert.ToInt32(Console.ReadLine());
            switch (opsiIce)
            {
                case (1):
                    {
                        Console.WriteLine("Pesanan Anda dengan {0} tanpa biaya tambahan Rp {1},00", takaranIce[0], hargaIce[0]);
                        ice = hargaIce[0];
                        iceDipilih = takaranIce[0];
                        break;
                    }
                case (2):
                    {
                        Console.WriteLine("Pesanan Anda dengan {0} tanpa biaya tambahan Rp {1},00", takaranIce[1], hargaIce[1]);
                        ice = hargaIce[1];
                        iceDipilih = takaranIce[1];
                        break;
                    }
                case (3):
                    {
                        Console.WriteLine("Dikenakan biaya tambahan untuk {0} ice sebesar Rp {1}", takaranIce[2], hargaIce[2]);
                        ice = hargaIce[2];
                        iceDipilih = takaranIce[2];
                        break;
                    }
                default:
                    {
                        goto InputIce;
                    }
            }
            int kuantitas;
            do
            {
                Console.Clear();
                Console.Write("Pesanan berikut dengan jumlah : ");
                kuantitas = Convert.ToInt32(Console.ReadLine());
            } while (kuantitas <= 0);

            int pcsMinuman = (menu + topping + gelas + gula + ice);
            pesanan = (kuantitas * pcsMinuman);
            string invoice= @"
 /$$$$$$ /$$   /$$ /$$    /$$  /$$$$$$  /$$$$$$  /$$$$$$  /$$$$$$$$
|_  $$_/| $$$ | $$| $$   | $$ /$$__  $$|_  $$_/ /$$__  $$| $$_____/
  | $$  | $$$$| $$| $$   | $$| $$  \ $$  | $$  | $$  \__/| $$      
  | $$  | $$ $$ $$|  $$ / $$/| $$  | $$  | $$  | $$      | $$$$$   
  | $$  | $$  $$$$ \  $$ $$/ | $$  | $$  | $$  | $$      | $$__/   
  | $$  | $$\  $$$  \  $$$/  | $$  | $$  | $$  | $$    $$| $$      
 /$$$$$$| $$ \  $$   \  $/   |  $$$$$$/ /$$$$$$|  $$$$$$/| $$$$$$$$
|______/|__/  \__/    \_/     \______/ |______/ \______/ |________/
                                                                   

";
            Console.Write(invoice);
            Console.WriteLine("NAMA MENU\t\t\t    HARGA");
            Console.WriteLine("===========================================");
            Console.WriteLine(menuDipilih + "\tRp {0},00", menu);
            Console.WriteLine("Topping " + toppingDipilih + "\t\t\tRp {0},00", topping);
            Console.WriteLine("Gelas " + gelasDipilih + "\t\t\tRp {0},00", gelas);
            Console.WriteLine(gulaDipilih + " Sugar" + "\t\t\tRp {0},00", gula);
            Console.WriteLine(iceDipilih + "\t\t\tRp {0},00", ice);
            Console.WriteLine("===========================================");
            Console.WriteLine("Harga/pcs\t\t\tRp {0},00", pcsMinuman);
            Console.WriteLine("TOTAL :\t Rp {0},00 x {1} pcs = Rp {2},00", pcsMinuman, kuantitas, pesanan);

            Console.WriteLine("\nMinuman Anda {0} \ndengan topping {1}, gelas {2}, takaran gula {3} serta {4}",
                              menuDipilih, toppingDipilih, gelasDipilih, gulaDipilih, iceDipilih);
            Console.WriteLine("Harga satu minuman Rp {0},00 dengan jumlah {1} = Rp {2},00", pcsMinuman, kuantitas, pesanan);

            kuantitasPesanan += kuantitas;
            totalHarga += pesanan;

            Console.Write("\n\nPress any key to buy\nIngin tambah pesanan (y)? ");
            char lanjutTransaksi = Convert.ToChar(Console.ReadLine());
            Console.Clear();
            switch (lanjutTransaksi)
            {
                case ('y'):
                    goto MulaiTransaksi;

                default:
                    Customer();
                    Console.WriteLine("\n\n\nPesanan {0} yang dibeli", customer);
                    Console.WriteLine("Total pesanan {0} : {1} pcs", customer, kuantitasPesanan);
                    Console.WriteLine("Total harus dibayar : Rp {0},00", totalHarga);

                    int bayar, kembali;
                    do
                    {
                        Console.Write("\nUang tunai dibayar  : Rp ");
                        bayar = int.Parse(Console.ReadLine());
                        //Formula untuk mendapatkan uang kembalian
                        kembali = bayar - totalHarga;

                        //Kondisi jika input uang bayar lebih kecil dari total harga
                        if (bayar < totalHarga)
                        {
                            Console.WriteLine("Maaf, uang anda kurang !!");
                            Console.WriteLine("-------------------------");
                        }

                        //Jika kondisi bernilai benar (input uang bayar lebih besar dari total harga)
                        else
                        {
                            Console.WriteLine("Uang kembalian Anda : Rp {0},00", kembali);
                        }
                    } while (bayar < totalHarga);
                    //Menampilkan tanggal dan waktu transaksi
                    Console.WriteLine("\n\n\t\t\tTanggal transaksi: " + DateTime.Today.ToString("dd-MM-yyyy"));
                    Console.WriteLine("\t\t\t  Waktu transaksi: " + DateTime.Now.ToString("HH:mm:ss"));

                    //Menampilkan ucapan terima kasih
                    Console.WriteLine("\n\n\t       ^_^ Terimakasih telah berbelanja di TeaTime ^_^");
                    totalHarga = 0;
                    kuantitas = 0;
                    break;
            }

        }

        static void GantiHargaMenu()
        {
            Console.WriteLine("FITUR INI AKAN MENGGANTI HARGA MENU MENJADI MANUAL INPUT");
            Console.WriteLine("========= HARGA BARU MMENU YANG DI INPUT > 0 ===========");
            DaftarMenu:
            Console.Write("Pilih menu yang akan diganti harganya (1 - 5) : ");

            int pilihMenu = Convert.ToInt32(Console.ReadLine());
            do
            {
                switch (pilihMenu)
                {
                    case (1):
                        Console.Write("Harga baru Brown Sugar Milk Tea : Rp ");
                        hargaMenu[0] = Convert.ToInt32(Console.ReadLine());
                        break;
                    case (2):
                        Console.Write("Harga baru Mango Green Tea      : Rp ");
                        hargaMenu[1] = Convert.ToInt32(Console.ReadLine());
                        break;
                    case (3):
                        Console.Write("Harga baru Taro Milk Tea        : Rp ");
                        hargaMenu[2] = Convert.ToInt32(Console.ReadLine());
                        break;
                    case (4):
                        Console.Write("Harga baru Hazelnut Chocolate Milk Tea : Rp ");
                        hargaMenu[3] = Convert.ToInt32(Console.ReadLine());
                        break;
                    case (5):
                        Console.Write("Harga baru Strawberry Milk Tea  : Rp ");
                        hargaMenu[4] = Convert.ToInt32(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("\nMasukkan no 1 - 5 !!!");
                        goto DaftarMenu;
                }
            } while (hargaMenu[0] <= 0 || hargaMenu[1] <= 0 || hargaMenu[2] <= 0 || hargaMenu[3] <= 0 || hargaMenu[4] <= 0);
            Console.Write("\nPress any key to close this fiture . . .\nMengganti harga menu lagi (y)? ");
            char pilih = Convert.ToChar(Console.ReadLine());
            if (pilih == 'y')
            {
                Console.Clear();
                DaftarMinumanTersedia();
                GantiHargaMenu();
            }
            else
            {
                return;
            }
        }
        static void GantiHargaTopping()
        {
            Console.WriteLine("FITUR INI AKAN MENGGANTI HARGA TOPPING MENJADI MANUAL INPUT");
            Console.WriteLine("===========HARGA BARU TOPPING YANG DI INPUT > 0 ===========");
            DaftarMenu:
            Console.Write("Pilih topping yang akan diganti harganya (1 - 4) : ");
            int pilihTopping = Convert.ToInt32(Console.ReadLine());
            do
            {
                switch (pilihTopping)
                {
                    case (1):
                        Console.Write("Harga baru topping Pearl menjadi : Rp ");
                        hargaTopping[0] = Convert.ToInt32(Console.ReadLine());
                        break;
                    case (2):
                        Console.Write("Harga baru topping Pudding menjadi : Rp ");
                        hargaTopping[1] = Convert.ToInt32(Console.ReadLine());
                        break;
                    case (3):
                        Console.Write("Harga baru topping Red bean menjadi : Rp ");
                        hargaTopping[2] = Convert.ToInt32(Console.ReadLine());
                        break;
                    case (4):
                        Console.Write("Harga baru topping Jelly menjadi : Rp ");
                        hargaTopping[3] = Convert.ToInt32(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("\nMasukkan no 1 - 4 !!!");
                        goto DaftarMenu;
                }
            } while (hargaTopping[0] <= 0 || hargaTopping[1] <= 0 || hargaTopping[2] <= 0 || hargaTopping[3] <= 0);
            Console.Write("\nPress any key to close this fiture . . .\nMengganti harga topping lagi (y)? ");
            char pilih = Convert.ToChar(Console.ReadLine());
            if (pilih == 'y')
            {
                Console.Clear();
                DaftarToppingTersedia();
                GantiHargaTopping();
            }
            else
            {
                return;
            }
        }

        static void ResetHarga()
        {
            //List Tetapan harga menu
            hargaMenu[0] = 4000;
            hargaMenu[1] = 6000;
            hargaMenu[2] = 5000;
            hargaMenu[3] = 7000;
            hargaMenu[4] = 9000;

            //List Tetapan harga topping
            hargaTopping[0] = 1500;
            hargaTopping[1] = 4000;
            hargaTopping[2] = 2500;
            hargaTopping[3] = 3000;
            DaftarMenuTersedia();
        }

        static void Main()
        {
            Console.Clear();
            BannerJudul();
            DaftarFitur();
            Console.Write("Pilihan fitur yang inginkan ( 1 - 4 )  : ");
            int pilihanFitur = int.Parse(Console.ReadLine());
            switch (pilihanFitur)
            {
                case (1):
                    {
                        Console.Clear();
                        BannerJudul();
                        DaftarMenuTersedia();
                        Console.Clear();
                        Transaksi();
                        Console.Write("\n\nPress any key to close this program . . .\nBack To Menu (y)? ");
                        char tutupHargaAwal = Convert.ToChar(Console.ReadLine());
                        if (tutupHargaAwal == 'y')
                        {
                            Main();
                            break;
                        }
                        else
                        {
                            return;
                        }
                    }
                case (2):
                    {
                        Console.Clear();
                        DaftarMinumanTersedia();
                        GantiHargaMenu();
                        kuantitasPesanan = 0;
                        totalHarga = 0;
                        Console.WriteLine("\n\nPress any number to close this program . . .\n1. Back To Menu (y)?\n2. Lanjut Transaksi");
                        Console.Write("Choose Number (1),(2)? ");
                        int tutupGantiHarga = Convert.ToInt32(Console.ReadLine());
                        if (tutupGantiHarga == 1)
                        {
                            Main();
                        }
                        if (tutupGantiHarga == 2)
                        {
                            LanjutTransaksi();
                            break;
                        }
                        else
                        {
                            return;
                        }
                    }
                case (3):
                    {
                        Console.Clear();
                        DaftarToppingTersedia();
                        GantiHargaTopping();
                        kuantitasPesanan = 0;
                        totalHarga = 0;
                        Console.WriteLine("\n\nPress any number to close this program . . .\n1. Back To Menu (y)?\n2. Lanjut Transaksi");
                        Console.Write("Choose Number (1),(2)? ");
                        int tutupGantiHargaTopping = Convert.ToInt32(Console.ReadLine());
                        if (tutupGantiHargaTopping == 1)
                        {
                            Main();
                            break;
                        }
                        if (tutupGantiHargaTopping == 2)
                        {
                            LanjutTransaksi();
                            break;
                        }
                        else
                        {
                            return;
                        }
                    }
                case (4):
                    Console.Clear();
                    string reset = @"
 /$$$$$$$  /$$$$$$$$  /$$$$$$  /$$$$$$$$ /$$$$$$$$       /$$   /$$  /$$$$$$  /$$$$$$$   /$$$$$$   /$$$$$$ 
| $$__  $$| $$_____/ /$$__  $$| $$_____/|__  $$__/      | $$  | $$ /$$__  $$| $$__  $$ /$$__  $$ /$$__  $$
| $$  \ $$| $$      | $$  \__/| $$         | $$         | $$  | $$| $$  \ $$| $$  \ $$| $$  \__/| $$  \ $$
| $$$$$$$/| $$$$$   |  $$$$$$ | $$$$$      | $$         | $$$$$$$$| $$$$$$$$| $$$$$$$/| $$ /$$$$| $$$$$$$$
| $$__  $$| $$__/    \____  $$| $$__/      | $$         | $$__  $$| $$__  $$| $$__  $$| $$|_  $$| $$__  $$
| $$  \ $$| $$       /$$  \ $$| $$         | $$         | $$  | $$| $$  | $$| $$  \ $$| $$  \ $$| $$  | $$
| $$  | $$| $$$$$$$$|  $$$$$$/| $$$$$$$$   | $$         | $$  | $$| $$  | $$| $$  | $$|  $$$$$$/| $$  | $$
|__/  |__/|________/ \______/ |________/   |__/         |__/  |__/|__/  |__/|__/  |__/ \______/ |__/  |__/
                                                                                                          
   
";
                    Console.WriteLine("\t"+reset);
                    ResetHarga();
                    Console.Write("\n\nPress any key to close this program . . .\nBack To Menu (y)? ");
                    char tutupResetHarga = Convert.ToChar(Console.ReadLine());
                    if (tutupResetHarga == 'y')
                    {
                        Main();
                        break;
                    }
                    else
                    {
                        return;
                    }
                default:
                    {
                        Console.Clear();
                        Main();
                        break;
                    }
            }
        }
    }
}
