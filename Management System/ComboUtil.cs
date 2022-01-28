﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind
{
	/// <summary>
	/// 使用方法請參考：
	/// https://blog.hungwin.com.tw/csharp-winform-combobox-value-text/#_ComboBoxItem
	/// </summary>

	public class ComboBoxItem
	{
		public ComboBoxItem(string value, string text)
		{
			Value = value;
			Text = text;
		}
		public string Value
		{
			get;
			set;
		}
		public string Text
		{
			get;
			set;
		}
		public override string ToString()
		{
			return Text;
		}
	}

	public static class ComboUtil
	{
		/// <summary>
		/// 設定下拉值
		/// </summary>
		/// <param name="cbo">物件</param>
		/// <param name="value">值</param>
		public static void SetItemValue(ComboBox cbo, string value)
		{
			var selectedObject = cbo.Items.Cast<ComboBoxItem>().SingleOrDefault(i => i.Value.Equals(value));
			if (selectedObject != null)
				cbo.SelectedIndex = cbo.FindStringExact(selectedObject.Text.ToString());
			else
				cbo.SelectedIndex = -1;
		}

		/// <summary>
		/// 取得下拉項目
		/// </summary>
		/// <param name="cbo">物件</param>
		/// <returns></returns>
		public static ComboBoxItem GetItem(ComboBox cbo)
		{
			ComboBoxItem item = new ComboBoxItem("", "");
			if (cbo.SelectedIndex > -1)
			{
				item = cbo.Items[cbo.SelectedIndex] as ComboBoxItem;
			}
			return item;
		}

		/// <summary>
		/// 取得索引下拉項目
		/// </summary>
		/// <param name="cbo">物件</param>
		/// <param name="index">索引</param>
		/// <returns></returns>
		public static ComboBoxItem GetItem(ComboBox cbo, int index)
		{
			ComboBoxItem item = null;
			if (index > -1)
			{
				item = cbo.Items[index] as ComboBoxItem;
			}
			return item;
		}

		/// <summary>
		/// 移除下拉項目
		/// </summary>
		/// <param name="cbo">物件</param>
		/// <param name="value">值</param>
		public static void RemoveItem(ComboBox cbo, string value)
		{
			ComboBoxItem selectedObject = cbo.Items.Cast<ComboBoxItem>().SingleOrDefault(i => i.Value.Equals(value));
			cbo.Items.Remove(selectedObject);
		}

		/// <summary>
		/// DataTable 綁定下拉項目
		/// </summary>
		/// <param name="cbo">物件</param>
		/// <param name="dt">資料集</param>
		/// <param name="valueColumn">值欄位</param>
		/// <param name="textColumn">名稱欄位</param>
		/// <param name="addEmpty">是否加空白選項</param>
		public static void BindTableToDDL(ComboBox cbo, DataTable dt, string valueColumn, string textColumn, bool addEmpty)
		{
			cbo.Items.Clear();
			if (addEmpty)
			{
				cbo.Items.Add(new ComboBoxItem("", ""));
			}
			foreach (DataRow dr in dt.Rows)
			{
				cbo.Items.Add(new ComboBoxItem(dr[valueColumn].ToString(), dr[textColumn].ToString()));
			}
			if (cbo.Items.Count > 0)
				cbo.SelectedIndex = 0;
		}

		/// <summary>
		/// sql 查詢結果綁定下拉項目
		/// </summary>
		/// <param name="cbo">物件</param>
		/// <param name="sql">sql查詢指令</param>
		/// <param name="valueColumn">值欄位</param>
		/// <param name="textColumn">名稱欄位</param>
		/// <param name="addEmpty">是否加空白選項</param>
		public static void BindTableToDDL(ComboBox cbo, string sql, string valueColumn, string textColumn, bool addEmpty)
		{
			cbo.Items.Clear();
			DataTable dt = DatabaseManagement.SqlQueryDataTable(sql);

			if (addEmpty)
			{
				cbo.Items.Add(new ComboBoxItem("", ""));
			}
			foreach (DataRow dr in dt.Rows)
			{
				cbo.Items.Add(new ComboBoxItem(dr[valueColumn].ToString(), dr[textColumn].ToString()));
			}
			if (cbo.Items.Count > 0)
				cbo.SelectedIndex = 0;
		}
	}
}
