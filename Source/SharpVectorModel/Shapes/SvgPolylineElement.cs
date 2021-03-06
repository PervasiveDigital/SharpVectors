using System;

namespace SharpVectors.Dom.Svg
{
	/// <summary>
	/// </summary>
    public sealed class SvgPolylineElement : SvgPolyElement, ISvgPolylineElement
	{
		public SvgPolylineElement(string prefix, string localname, string ns, SvgDocument doc)
			: base(prefix, localname, ns, doc)
		{		
		}

        #region Implementation of IElementVisitorTarget

        public void Accept(IElementVisitor visitor)
        {
            visitor.Visit(this);
        }

        #endregion
    }
}
