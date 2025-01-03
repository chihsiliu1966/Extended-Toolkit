﻿#region MIT License
/*
 *
 * MIT License
 *
 * Copyright (c) 2017 - 2024 Krypton Suite
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 *
 */
#endregion

namespace Krypton.Toolkit.Suite.Extended.Utilities.System.GrammarBuilding
{
    internal sealed class OneOfElement : BuilderElements
    {
        internal override string DebugSummary
        {
            get
            {
                StringBuilder stringBuilder = new StringBuilder();
                foreach (GrammarBuilderBase item in base.Items)
                {
                    if (stringBuilder.Length > 0)
                    {
                        stringBuilder.Append(",");
                    }
                    stringBuilder.Append(item.DebugSummary);
                }
                return $"[{stringBuilder}]";
            }
        }

        internal OneOfElement()
        {
        }

        internal override GrammarBuilderBase Clone()
        {
            OneOfElement oneOfElement = new OneOfElement();
            oneOfElement.CloneItems(this);
            return oneOfElement;
        }

        internal override IElement CreateElement(IElementFactory elementFactory, IElement parent, IRule rule, IdentifierCollection ruleIds)
        {
            IOneOf oneOf = elementFactory.CreateOneOf(parent, rule);
            foreach (GrammarBuilderBase item2 in base.Items)
            {
                ItemElement itemElement = item2 as ItemElement;
                if (itemElement == null)
                {
                    itemElement = new ItemElement(item2);
                }
                IItem item = (IItem)itemElement.CreateElement(elementFactory, oneOf, rule, ruleIds);
                item.PostParse(oneOf);
                elementFactory.AddItem(oneOf, item);
            }
            return oneOf;
        }
    }
}