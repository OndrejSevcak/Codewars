using Codewars._5kyu;

Console.WriteLine("Welcome");

//RecreationOne.Test();

PaginationHelperTest();



void PaginationHelperTest()
{
    var helper = new PaginationHelper<char>(new List<char> { 'a', 'b', 'c', 'd', 'e', 'f' }, 4);

    int pageCnt = helper.PageCount; // should == 2
    int itemCnt = helper.ItemCount; // should == 6
    int pageItems0 = helper.PageItemCount(0); // should == 4
    int pageItems1 = helper.PageItemCount(1); // last page - should == 2
    int pageItems2 = helper.PageItemCount(2); // should == -1 since the page is invalid
    int pageItems3 = helper.PageItemCount(-1); // should == -1 since the page is invalid


    // pageIndex takes an item index and returns the page that it belongs on
    int pageIndex0 = helper.PageIndex(5); // should == 1 (zero based index)
    int pageIndex1 = helper.PageIndex(2); // should == 0
    int pageIndex2 = helper.PageIndex(20); // should == -1
    int pageIndex3 = helper.PageIndex(-10); // should == -1
    int pageIndex4 = helper.PageIndex(0); // should == 0
    int pageIndex5 = helper.PageIndex(6); // should == 1

}