using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Tests
{
    public interface ISplitLinesProvider
    {
        List<string[]> GetLinesElements(IFileInfo fileInfo);
    }
}
