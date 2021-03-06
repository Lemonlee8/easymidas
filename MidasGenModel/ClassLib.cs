using System;
using System.Collections.Generic;
using System.Xml.Serialization;			// for various Xml attributes
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary; 

namespace MidasGenModel
{
    /// <summary>
    /// 主控制程序类
    /// </summary>
    public static class Application
    {
        /// <summary>
        /// 存储模型数据为二进制文件
        /// </summary>
        /// <param name="model">模型数据对像</param>
        /// <param name="FileName">存储文件位置及名称</param>
        static public void WriteModelBinary(model.Bmodel model,string FileName)
        {
            using (FileStream fs = new FileStream(FileName,FileMode.Create))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, model);
                fs.Close();
            }
        }
        /// <summary>
        /// 反序列化模型数据二进制文件
        /// </summary>
        /// <param name="FileName">二进制文件路径</param>
        /// <param name="mm">模型对像引用</param>
        static public model.Bmodel ReadModelBinary(string FileName)
        {
            using (FileStream fs = new FileStream(FileName, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                BinaryFormatter bf = new BinaryFormatter();
                model.Bmodel mm=(model.Bmodel) bf.Deserialize(fs);
                return mm;
            }
        }

        /// <summary>
        /// 存储验算结果数据为二进制文件
        /// </summary>
        /// <param name="model">模型数据对像</param>
        /// <param name="FileName">存储文件位置及名称</param>
        static public void WriteCheckBinary(MidasGenModel.Design.CheckRes CR, string FileName)
        {
            using (FileStream fs = new FileStream(FileName, FileMode.Create))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, CR);
                fs.Close();
            }
        }

        /// <summary>
        /// 反序列化模型数据二进制文件
        /// </summary>
        /// <param name="FileName">二进制文件路径</param>
        /// <param name="mm">模型对像引用</param>
        static public MidasGenModel.Design.CheckRes ReadCheckBinary(string FileName)
        {
            using (FileStream fs = new FileStream(FileName, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                BinaryFormatter bf = new BinaryFormatter();
                MidasGenModel.Design.CheckRes cr = (MidasGenModel.Design.CheckRes)bf.Deserialize(fs);
                return cr;
            }
        }
    }

}
