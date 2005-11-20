using System.Collections;
using AODL.Collections;

namespace AODL.TextDocument.Content
{
	/// <summary>
	/// A Column collection
	/// </summary>
	public class ColumnCollection : CollectionWithEvents
	{
		/// <summary>
		/// Adds the specified value.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns></returns>
		public int Add(AODL.TextDocument.Content.Column value)
		{
			return base.List.Add(value as object);
		}

		/// <summary>
		/// Removes the specified value.
		/// </summary>
		/// <param name="value">The value.</param>
		public void Remove(AODL.TextDocument.Content.Column value)
		{
			base.List.Remove(value as object);
		}

		/// <summary>
		/// Inserts the specified index.
		/// </summary>
		/// <param name="index">The index.</param>
		/// <param name="value">The value.</param>
		public void Insert(int index, AODL.TextDocument.Content.Column value)
		{
			base.List.Insert(index, value as object);
		}

		/// <summary>
		/// Determines whether [contains] [the specified value].
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>
		/// 	<c>true</c> if [contains] [the specified value]; otherwise, <c>false</c>.
		/// </returns>
		public bool Contains(AODL.TextDocument.Content.Column value)
		{
			return base.List.Contains(value as object);
		}

		/// <summary>
		/// Gets the <see cref="Column"/> at the specified index.
		/// </summary>
		/// <value></value>
		public AODL.TextDocument.Content.Column this[int index]
		{
			get { return (base.List[index] as AODL.TextDocument.Content.Column); }
		}
	}
}