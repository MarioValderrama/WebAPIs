using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("SIDUSERS")]
    public partial class Sidusers
    {
        [Key]
        [Column("USER")]
        [StringLength(8)]
        public string User { get; set; }
        [Column("NOMBRE")]
        [StringLength(50)]
        public string Nombre { get; set; }
        [Column("PASO1")]
        public double? Paso1 { get; set; }
        [Column("PASO2")]
        public double? Paso2 { get; set; }
        [Column("PASO3")]
        public double? Paso3 { get; set; }
        [Column("PASO4")]
        public double? Paso4 { get; set; }
        [Column("PASO5")]
        public double? Paso5 { get; set; }
        [Column("PASO6")]
        public double? Paso6 { get; set; }
        [Column("PASO7")]
        public double? Paso7 { get; set; }
        [Column("PASO8")]
        public double? Paso8 { get; set; }
        [Column("CUANTOS")]
        public int? Cuantos { get; set; }
        [Column("MP1")]
        [StringLength(1)]
        public string Mp1 { get; set; }
        [Column("SM1_01")]
        [StringLength(1)]
        public string Sm101 { get; set; }
        [Column("SM1_02")]
        [StringLength(1)]
        public string Sm102 { get; set; }
        [Column("SM1_03")]
        [StringLength(1)]
        public string Sm103 { get; set; }
        [Column("SM1_04")]
        [StringLength(1)]
        public string Sm104 { get; set; }
        [Column("SM1_05")]
        [StringLength(1)]
        public string Sm105 { get; set; }
        [Column("SM1_06")]
        [StringLength(1)]
        public string Sm106 { get; set; }
        [Column("SM1_07")]
        [StringLength(1)]
        public string Sm107 { get; set; }
        [Column("SM1_08")]
        [StringLength(1)]
        public string Sm108 { get; set; }
        [Column("SM1_09")]
        [StringLength(1)]
        public string Sm109 { get; set; }
        [Column("SM1_10")]
        [StringLength(1)]
        public string Sm110 { get; set; }
        [Column("SM1_11")]
        [StringLength(1)]
        public string Sm111 { get; set; }
        [Column("SM1_12")]
        [StringLength(1)]
        public string Sm112 { get; set; }
        [Column("SM1_13")]
        [StringLength(1)]
        public string Sm113 { get; set; }
        [Column("SM1_14")]
        [StringLength(1)]
        public string Sm114 { get; set; }
        [Column("SM1_14_01")]
        [StringLength(1)]
        public string Sm11401 { get; set; }
        [Column("SM1_14_02")]
        [StringLength(1)]
        public string Sm11402 { get; set; }
        [Column("SM1_14_03")]
        [StringLength(1)]
        public string Sm11403 { get; set; }
        [Column("SM1_15")]
        [StringLength(1)]
        public string Sm115 { get; set; }
        [Column("SM1_15_01")]
        [StringLength(1)]
        public string Sm11501 { get; set; }
        [Column("SM1_15_02")]
        [StringLength(1)]
        public string Sm11502 { get; set; }
        [Column("SM1_15_03")]
        [StringLength(1)]
        public string Sm11503 { get; set; }
        [Column("SM1_16")]
        [StringLength(1)]
        public string Sm116 { get; set; }
        [Column("SM1_17")]
        [StringLength(1)]
        public string Sm117 { get; set; }
        [Column("MP2")]
        [StringLength(1)]
        public string Mp2 { get; set; }
        [Column("SM2_01")]
        [StringLength(1)]
        public string Sm201 { get; set; }
        [Column("SM2_02")]
        [StringLength(1)]
        public string Sm202 { get; set; }
        [Column("SM2_03")]
        [StringLength(1)]
        public string Sm203 { get; set; }
        [Column("SM2_04")]
        [StringLength(1)]
        public string Sm204 { get; set; }
        [Column("MP3")]
        [StringLength(1)]
        public string Mp3 { get; set; }
        [Column("SM3_01")]
        [StringLength(1)]
        public string Sm301 { get; set; }
        [Column("SM3_02")]
        [StringLength(1)]
        public string Sm302 { get; set; }
        [Column("SM3_03")]
        [StringLength(1)]
        public string Sm303 { get; set; }
        [Column("SM3_04")]
        [StringLength(1)]
        public string Sm304 { get; set; }
        [Column("SM3_05")]
        [StringLength(1)]
        public string Sm305 { get; set; }
        [Column("SM3_06")]
        [StringLength(1)]
        public string Sm306 { get; set; }
        [Column("SM3_07")]
        [StringLength(1)]
        public string Sm307 { get; set; }
        [Column("MP4")]
        [StringLength(1)]
        public string Mp4 { get; set; }
        [Column("SM4_01")]
        [StringLength(1)]
        public string Sm401 { get; set; }
        [Column("SM4_01_01")]
        [StringLength(1)]
        public string Sm40101 { get; set; }
        [Column("SM4_01_02")]
        [StringLength(1)]
        public string Sm40102 { get; set; }
        [Column("SM4_01_03")]
        [StringLength(1)]
        public string Sm40103 { get; set; }
        [Column("SM4_01_04")]
        [StringLength(1)]
        public string Sm40104 { get; set; }
        [Column("SM4_01_05")]
        [StringLength(1)]
        public string Sm40105 { get; set; }
        [Column("SM4_01_06")]
        [StringLength(1)]
        public string Sm40106 { get; set; }
        [Column("SM4_01_07")]
        [StringLength(1)]
        public string Sm40107 { get; set; }
        [Column("SM4_01_08")]
        [StringLength(1)]
        public string Sm40108 { get; set; }
        [Column("SM4_01_09")]
        [StringLength(1)]
        public string Sm40109 { get; set; }
        [Column("SM4_01_10")]
        [StringLength(1)]
        public string Sm40110 { get; set; }
        [Column("SM4_01_11")]
        [StringLength(1)]
        public string Sm40111 { get; set; }
        [Column("SM4_01_12")]
        [StringLength(1)]
        public string Sm40112 { get; set; }
        [Column("SM4_01_13")]
        [StringLength(1)]
        public string Sm40113 { get; set; }
        [Column("SM4_01_14")]
        [StringLength(1)]
        public string Sm40114 { get; set; }
        [Column("SM4_01_15")]
        [StringLength(1)]
        public string Sm40115 { get; set; }
        [Column("SM4_02")]
        [StringLength(1)]
        public string Sm402 { get; set; }
        [Column("SM4_02_01")]
        [StringLength(1)]
        public string Sm40201 { get; set; }
        [Column("SM4_02_02")]
        [StringLength(1)]
        public string Sm40202 { get; set; }
        [Column("SM4_02_03")]
        [StringLength(1)]
        public string Sm40203 { get; set; }
        [Column("SM4_02_04")]
        [StringLength(1)]
        public string Sm40204 { get; set; }
        [Column("SM4_02_05")]
        [StringLength(1)]
        public string Sm40205 { get; set; }
        [Column("SM4_02_06")]
        [StringLength(1)]
        public string Sm40206 { get; set; }
        [Column("SM4_02_07")]
        [StringLength(1)]
        public string Sm40207 { get; set; }
        [Column("SM4_02_08")]
        [StringLength(1)]
        public string Sm40208 { get; set; }
        [Column("SM4_02_09")]
        [StringLength(1)]
        public string Sm40209 { get; set; }
        [Column("SM4_02_10")]
        [StringLength(1)]
        public string Sm40210 { get; set; }
        [Column("SM4_02_11")]
        [StringLength(1)]
        public string Sm40211 { get; set; }
        [Column("SM4_02_12")]
        [StringLength(1)]
        public string Sm40212 { get; set; }
        [Column("SM4_03")]
        [StringLength(1)]
        public string Sm403 { get; set; }
        [Column("SM4_03_01")]
        [StringLength(1)]
        public string Sm40301 { get; set; }
        [Column("SM4_03_02")]
        [StringLength(1)]
        public string Sm40302 { get; set; }
        [Column("SM4_03_03")]
        [StringLength(1)]
        public string Sm40303 { get; set; }
        [Column("SM4_04")]
        [StringLength(1)]
        public string Sm404 { get; set; }
        [Column("SM4_04_01")]
        [StringLength(1)]
        public string Sm40401 { get; set; }
        [Column("SM4_04_02")]
        [StringLength(1)]
        public string Sm40402 { get; set; }
        [Column("SM4_04_03")]
        [StringLength(1)]
        public string Sm40403 { get; set; }
        [Column("SM4_04_04")]
        [StringLength(1)]
        public string Sm40404 { get; set; }
        [Column("SM4_05")]
        [StringLength(1)]
        public string Sm405 { get; set; }
        [Column("SM4_05_01")]
        [StringLength(1)]
        public string Sm40501 { get; set; }
        [Column("SM4_05_02")]
        [StringLength(1)]
        public string Sm40502 { get; set; }
        [Column("SM4_05_03")]
        [StringLength(1)]
        public string Sm40503 { get; set; }
        [Column("SM4_05_04")]
        [StringLength(1)]
        public string Sm40504 { get; set; }
        [Column("SM4_06")]
        [StringLength(1)]
        public string Sm406 { get; set; }
        [Column("SM4_07")]
        [StringLength(1)]
        public string Sm407 { get; set; }
        [Column("SM4_07_01")]
        [StringLength(1)]
        public string Sm40701 { get; set; }
        [Column("SM4_07_02")]
        [StringLength(1)]
        public string Sm40702 { get; set; }
        [Column("SM4_07_03")]
        [StringLength(1)]
        public string Sm40703 { get; set; }
        [Column("SM4_07_04")]
        [StringLength(1)]
        public string Sm40704 { get; set; }
        [Column("SM4_07_05")]
        [StringLength(1)]
        public string Sm40705 { get; set; }
        [Column("SM4_07_06")]
        [StringLength(1)]
        public string Sm40706 { get; set; }
        [Column("SM4_07_07")]
        [StringLength(1)]
        public string Sm40707 { get; set; }
        [Column("SM4_08")]
        [StringLength(1)]
        public string Sm408 { get; set; }
        [Column("SM4_08_01")]
        [StringLength(1)]
        public string Sm40801 { get; set; }
        [Column("SM4_08_02")]
        [StringLength(1)]
        public string Sm40802 { get; set; }
        [Column("SM4_08_03")]
        [StringLength(1)]
        public string Sm40803 { get; set; }
        [Column("SM4_08_04")]
        [StringLength(1)]
        public string Sm40804 { get; set; }
        [Column("SM4_08_05")]
        [StringLength(1)]
        public string Sm40805 { get; set; }
        [Column("SM4_09")]
        [StringLength(1)]
        public string Sm409 { get; set; }
        [Column("SM4_09_01")]
        [StringLength(1)]
        public string Sm40901 { get; set; }
        [Column("SM4_09_02")]
        [StringLength(1)]
        public string Sm40902 { get; set; }
        [Column("SM4_09_03")]
        [StringLength(1)]
        public string Sm40903 { get; set; }
        [Column("SM4_09_04")]
        [StringLength(1)]
        public string Sm40904 { get; set; }
        [Column("SM4_09_05")]
        [StringLength(1)]
        public string Sm40905 { get; set; }
        [Column("SM4_10")]
        [StringLength(1)]
        public string Sm410 { get; set; }
        [Column("SM4_10_01")]
        [StringLength(1)]
        public string Sm41001 { get; set; }
        [Column("SM4_10_02")]
        [StringLength(1)]
        public string Sm41002 { get; set; }
        [Column("SM4_11")]
        [StringLength(1)]
        public string Sm411 { get; set; }
        [Column("SM4_11_01")]
        [StringLength(1)]
        public string Sm41101 { get; set; }
        [Column("SM4_11_02")]
        [StringLength(1)]
        public string Sm41102 { get; set; }
        [Column("MP5")]
        [StringLength(1)]
        public string Mp5 { get; set; }
        [Column("SM5_01")]
        [StringLength(1)]
        public string Sm501 { get; set; }
        [Column("SM5_01_01")]
        [StringLength(1)]
        public string Sm50101 { get; set; }
        [Column("SM5_01_02")]
        [StringLength(1)]
        public string Sm50102 { get; set; }
        [Column("SM5_01_03")]
        [StringLength(1)]
        public string Sm50103 { get; set; }
        [Column("SM5_01_04")]
        [StringLength(1)]
        public string Sm50104 { get; set; }
        [Column("SM5_01_05")]
        [StringLength(1)]
        public string Sm50105 { get; set; }
        [Column("SM5_01_06")]
        [StringLength(1)]
        public string Sm50106 { get; set; }
        [Column("SM5_01_07")]
        [StringLength(1)]
        public string Sm50107 { get; set; }
        [Column("SM5_01_08")]
        [StringLength(1)]
        public string Sm50108 { get; set; }
        [Column("SM5_01_09")]
        [StringLength(1)]
        public string Sm50109 { get; set; }
        [Column("SM5_01_10")]
        [StringLength(1)]
        public string Sm50110 { get; set; }
        [Column("SM5_01_11")]
        [StringLength(1)]
        public string Sm50111 { get; set; }
        [Column("SM5_02")]
        [StringLength(1)]
        public string Sm502 { get; set; }
        [Column("SM5_02_01")]
        [StringLength(1)]
        public string Sm50201 { get; set; }
        [Column("SM5_02_02")]
        [StringLength(1)]
        public string Sm50202 { get; set; }
        [Column("SM5_02_03")]
        [StringLength(1)]
        public string Sm50203 { get; set; }
        [Column("SM5_02_04")]
        [StringLength(1)]
        public string Sm50204 { get; set; }
        [Column("SM5_02_05")]
        [StringLength(1)]
        public string Sm50205 { get; set; }
        [Column("SM5_02_06")]
        [StringLength(1)]
        public string Sm50206 { get; set; }
        [Column("SM5_02_07")]
        [StringLength(1)]
        public string Sm50207 { get; set; }
        [Column("SM5_02_08")]
        [StringLength(1)]
        public string Sm50208 { get; set; }
        [Column("SM5_03")]
        [StringLength(1)]
        public string Sm503 { get; set; }
        [Column("SM5_04")]
        [StringLength(1)]
        public string Sm504 { get; set; }
        [Column("SM5_05")]
        [StringLength(1)]
        public string Sm505 { get; set; }
        [Column("SM5_06")]
        [StringLength(1)]
        public string Sm506 { get; set; }
        [Column("SM5_07")]
        [StringLength(1)]
        public string Sm507 { get; set; }
        [Column("SM5_08")]
        [StringLength(1)]
        public string Sm508 { get; set; }
        [Column("SM5_09")]
        [StringLength(1)]
        public string Sm509 { get; set; }
        [Column("SM5_10")]
        [StringLength(1)]
        public string Sm510 { get; set; }
        [Column("SM5_11")]
        [StringLength(1)]
        public string Sm511 { get; set; }
        [Column("SM5_12")]
        [StringLength(1)]
        public string Sm512 { get; set; }
        [Column("SM5_13")]
        [StringLength(1)]
        public string Sm513 { get; set; }
        [Column("SM5_14")]
        [StringLength(1)]
        public string Sm514 { get; set; }
        [Column("SM5_14_01")]
        [StringLength(1)]
        public string Sm51401 { get; set; }
        [Column("SM5_14_02")]
        [StringLength(1)]
        public string Sm51402 { get; set; }
        [Column("SM5_15")]
        [StringLength(1)]
        public string Sm515 { get; set; }
        [Column("SM5_15_01")]
        [StringLength(1)]
        public string Sm51501 { get; set; }
        [Column("SM5_15_02")]
        [StringLength(1)]
        public string Sm51502 { get; set; }
        [Column("SM5_16")]
        [StringLength(1)]
        public string Sm516 { get; set; }
        [Column("MP6")]
        [StringLength(1)]
        public string Mp6 { get; set; }
        [Column("SM6_01")]
        [StringLength(1)]
        public string Sm601 { get; set; }
        [Column("SM6_02")]
        [StringLength(1)]
        public string Sm602 { get; set; }
        [Column("SM6_03")]
        [StringLength(1)]
        public string Sm603 { get; set; }
        [Column("SM6_03_01")]
        [StringLength(1)]
        public string Sm60301 { get; set; }
        [Column("SM6_03_02")]
        [StringLength(1)]
        public string Sm60302 { get; set; }
        [Column("SM6_03_03")]
        [StringLength(1)]
        public string Sm60303 { get; set; }
        [Column("SM6_04")]
        [StringLength(1)]
        public string Sm604 { get; set; }
        [Column("SM6_05")]
        [StringLength(1)]
        public string Sm605 { get; set; }
        [Column("SM6_06")]
        [StringLength(1)]
        public string Sm606 { get; set; }
        [Column("SM6_07")]
        [StringLength(1)]
        public string Sm607 { get; set; }
        [Column("SM6_08")]
        [StringLength(1)]
        public string Sm608 { get; set; }
        [Column("SM6_09")]
        [StringLength(1)]
        public string Sm609 { get; set; }
        [Column("SM6_10")]
        [StringLength(1)]
        public string Sm610 { get; set; }
        [Column("SM6_11")]
        [StringLength(1)]
        public string Sm611 { get; set; }
        [Column("SM6_12")]
        [StringLength(1)]
        public string Sm612 { get; set; }
        [Column("SM6_13")]
        [StringLength(1)]
        public string Sm613 { get; set; }
        [Column("SM6_14")]
        [StringLength(1)]
        public string Sm614 { get; set; }
        [Column("SM6_15")]
        [StringLength(1)]
        public string Sm615 { get; set; }
        [Column("MP7")]
        [StringLength(1)]
        public string Mp7 { get; set; }
        [Column("SM7_01")]
        [StringLength(1)]
        public string Sm701 { get; set; }
        [Column("SM7_02")]
        [StringLength(1)]
        public string Sm702 { get; set; }
        [Column("SM7_03")]
        [StringLength(1)]
        public string Sm703 { get; set; }
        [Column("SM7_04")]
        [StringLength(1)]
        public string Sm704 { get; set; }
        [Column("MP8")]
        [StringLength(1)]
        public string Mp8 { get; set; }
        [Column("SM8_01")]
        [StringLength(1)]
        public string Sm801 { get; set; }
        [Column("SM8_02")]
        [StringLength(1)]
        public string Sm802 { get; set; }
        [Column("SM8_03")]
        [StringLength(1)]
        public string Sm803 { get; set; }
        [Column("SM8_04")]
        [StringLength(1)]
        public string Sm804 { get; set; }
        [Column("SM8_05")]
        [StringLength(1)]
        public string Sm805 { get; set; }
        [Column("SM8_05_01")]
        [StringLength(1)]
        public string Sm80501 { get; set; }
        [Column("SM8_05_02")]
        [StringLength(1)]
        public string Sm80502 { get; set; }
        [Column("SM8_05_03")]
        [StringLength(1)]
        public string Sm80503 { get; set; }
        [Column("SM8_05_04")]
        [StringLength(1)]
        public string Sm80504 { get; set; }
        [Column("SM8_06")]
        [StringLength(1)]
        public string Sm806 { get; set; }
        [Column("SM8_07")]
        [StringLength(1)]
        public string Sm807 { get; set; }
        [Column("SM8_07_01")]
        [StringLength(1)]
        public string Sm80701 { get; set; }
        [Column("SM8_07_02")]
        [StringLength(1)]
        public string Sm80702 { get; set; }
        [Column("SM8_07_03")]
        [StringLength(1)]
        public string Sm80703 { get; set; }
        [Column("SM8_08")]
        [StringLength(1)]
        public string Sm808 { get; set; }
        [Column("SM8_09")]
        [StringLength(1)]
        public string Sm809 { get; set; }
        [Column("SM8_10")]
        [StringLength(1)]
        public string Sm810 { get; set; }
        [Column("SM8_11")]
        [StringLength(1)]
        public string Sm811 { get; set; }
        [Column("SM8_12")]
        [StringLength(1)]
        public string Sm812 { get; set; }
        [Column("SM8_13")]
        [StringLength(1)]
        public string Sm813 { get; set; }
        [Column("SM8_14")]
        [StringLength(1)]
        public string Sm814 { get; set; }
        [Column("SM8_14_01")]
        [StringLength(1)]
        public string Sm81401 { get; set; }
        [Column("SM8_14_02")]
        [StringLength(1)]
        public string Sm81402 { get; set; }
        [Column("SM8_14_03")]
        [StringLength(1)]
        public string Sm81403 { get; set; }
        [Column("SM8_15")]
        [StringLength(1)]
        public string Sm815 { get; set; }
        [Column("SM8_15_01")]
        [StringLength(1)]
        public string Sm81501 { get; set; }
        [Column("SM8_16")]
        [StringLength(1)]
        public string Sm816 { get; set; }
        [Column("MP9")]
        [StringLength(1)]
        public string Mp9 { get; set; }
        [Column("SM9_01")]
        [StringLength(1)]
        public string Sm901 { get; set; }
        [Column("SM9_02")]
        [StringLength(1)]
        public string Sm902 { get; set; }
        [Column("SM9_03")]
        [StringLength(1)]
        public string Sm903 { get; set; }
        [Column("SM9_04")]
        [StringLength(1)]
        public string Sm904 { get; set; }
        [Column("SM9_05")]
        [StringLength(1)]
        public string Sm905 { get; set; }
        [Column("SM9_06")]
        [StringLength(1)]
        public string Sm906 { get; set; }
        [Column("SM9_07")]
        [StringLength(1)]
        public string Sm907 { get; set; }
        [Column("SM9_08")]
        [StringLength(1)]
        public string Sm908 { get; set; }
        [Column("SM9_09")]
        [StringLength(1)]
        public string Sm909 { get; set; }
        [Column("SM9_10")]
        [StringLength(1)]
        public string Sm910 { get; set; }
        [Column("MP10")]
        [StringLength(1)]
        public string Mp10 { get; set; }
        [Column("SM10_01")]
        [StringLength(1)]
        public string Sm1001 { get; set; }
        [Column("SM10_02")]
        [StringLength(1)]
        public string Sm1002 { get; set; }
        [Column("SM10_03")]
        [StringLength(1)]
        public string Sm1003 { get; set; }
        [Column("SM10_04")]
        [StringLength(1)]
        public string Sm1004 { get; set; }
        [Column("SM10_05")]
        [StringLength(1)]
        public string Sm1005 { get; set; }
        [Column("SM5_02_09")]
        [StringLength(1)]
        public string Sm50209 { get; set; }
        [Column("SM3_08")]
        [StringLength(1)]
        public string Sm308 { get; set; }
        [Column("SM3_09")]
        [StringLength(1)]
        public string Sm309 { get; set; }
        [Column("SM3_10")]
        [StringLength(1)]
        public string Sm310 { get; set; }
        [Column("SM4_01_16")]
        [StringLength(1)]
        public string Sm40116 { get; set; }
        [Column("SM5_15_03")]
        [StringLength(1)]
        public string Sm51503 { get; set; }
        [Column("SM8_14_04")]
        [StringLength(1)]
        public string Sm81404 { get; set; }
        [Column("SM8_15_02")]
        [StringLength(1)]
        public string Sm81502 { get; set; }
        [Column("SM4_08_06")]
        [StringLength(1)]
        public string Sm40806 { get; set; }
        [Column("SM4_08_07")]
        [StringLength(1)]
        public string Sm40807 { get; set; }
        [Column("SM4_08_08")]
        [StringLength(1)]
        public string Sm40808 { get; set; }
        [Column("SM4_08_09")]
        [StringLength(1)]
        public string Sm40809 { get; set; }
        [Column("SM4_08_10")]
        [StringLength(1)]
        public string Sm40810 { get; set; }
        [Column("SM3_11")]
        [StringLength(1)]
        public string Sm311 { get; set; }
        [Column("SM4_01_17")]
        [StringLength(1)]
        public string Sm40117 { get; set; }
        [Column("SM3_12")]
        [StringLength(1)]
        public string Sm312 { get; set; }
        [Required]
        [Column("SSMA_TimeStamp")]
        public byte[] SsmaTimeStamp { get; set; }
    }
}
