using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acadametrics.Data.Models
{
  public class FileAttachment
  {
    public int FileId { get; set; }
    public string FileName { get; set; }
    public string FilePath { get; set; }
    public string FileType { get; set; }

    public static IList<FileAttachment> CreateFileAttachments()
    {
      List<FileAttachment> fileAttachmentsList = new List<FileAttachment>{
        new FileAttachment{
          FileId=60001,
          FileName="Whiteboard drawing of some stuff",
          FilePath="//files.example.com/1234/1001/whiteboard-drawing-stuff.png",
          FileType="PNG"
        },
        new FileAttachment{
          FileId=60021,
          FileName="Blackboard drawing of some other stuff",
          FilePath="//files.example.com/1234/1001/whiteboard-drawing-stuff2.png",
          FileType="PNG"
        }
      };

      return fileAttachmentsList;
    }
  }
}
