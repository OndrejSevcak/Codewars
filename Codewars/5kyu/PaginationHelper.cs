using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;


namespace Codewars._5kyu
{
    //The class is designed to take in an array of values and an integer indicating how many items will be allowed per each page.
    //The types of values contained within the collection/array are not relevant.
    public class PaginationHelper<T>
    {
        private IList<T> _collection;
        private int _itemsPerPage;

        /// <summary>
        /// Constructor, takes in a list of items and the number of items that fit within a single page
        /// </summary>
        /// <param name="collection">A list of items</param>
        /// <param name="itemsPerPage">The number of items that fit within a single page</param>
        public PaginationHelper(IList<T> collection, int itemsPerPage)
        {
            _collection = collection;
            _itemsPerPage = itemsPerPage;
        }

        /// <summary>
        /// The number of items within the collection
        /// </summary>
        public int ItemCount
        {
            get
            {
                return _collection.Count;
            }
        }

        /// <summary>
        /// The number of pages
        /// </summary>
        public int PageCount
        {
            get
            {
                int modulo = _collection.Count % _itemsPerPage;
                double division = _collection.Count / _itemsPerPage;

                if(_collection.Count == 0)
                {
                    return 0;
                }

                if (modulo == 0)
                {
                    return (int)Math.Round(division, 0, MidpointRounding.AwayFromZero);
                }
                else
                {
                    return (int)Math.Round(division, 0, MidpointRounding.AwayFromZero) + 1;

                }
            }
        }

        /// <summary>
        /// Returns the number of items in the page at the given page index 
        /// </summary>
        /// <param name="pageIndex">The zero-based page index to get the number of items for</param>
        /// <returns>The number of items on the specified page or -1 for pageIndex values that are out of range</returns>
        public int PageItemCount(int pageIndex)
        {
            var modulo = _collection.Count % _itemsPerPage;

            if(pageIndex > PageCount - 1 || pageIndex < 0)
            {
                return -1;
            }

            if (pageIndex == PageCount - 1) //last page
            {
                if(modulo == 0)
                {
                    return _itemsPerPage;
                }
                return modulo;
            }
            return _itemsPerPage;
        }

        /// <summary>
        /// Returns the page index of the page containing the item at the given item index.
        /// </summary>
        /// <param name="itemIndex">The zero-based index of the item to get the pageIndex for</param>
        /// <returns>The zero-based page index of the page containing the item at the given item index or -1 if the item index is out of range</returns>
        public int PageIndex(int itemIndex)
        {
            if(itemIndex > _collection.Count - 1 || itemIndex < 0)
            {
                return -1;
            }
            else if(itemIndex == 0)
            {
                return 0;
            }

            var modulo = (itemIndex + 1) % _itemsPerPage;
            if (modulo == 0)
            {
                return ((itemIndex + 1) / _itemsPerPage) - 1;
            }

            double division = (itemIndex + 1) / _itemsPerPage;
            return (int)Math.Round(division, 0, MidpointRounding.AwayFromZero);
        }
    }
}
