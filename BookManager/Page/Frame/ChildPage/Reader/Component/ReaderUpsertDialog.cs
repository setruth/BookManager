using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AntdUI;
using BookManager.Component;
using BookManager.DB.Entity;
using BookManager.DB.Repository;
using BookManager.Page.Frame.ChildPage.Reader.Model;
using BookManager.Util;

namespace BookManager.Page.Frame.ChildPage.Reader.Component
{
    public partial class ReaderInfoUpsertDialog : BaseDialog
    {
        private readonly ReaderInfo? defaultInfo;
        private readonly ReaderTypeRepository readerTypeRep = ReaderTypeRepository.GetRep();
        private readonly Action<ReaderInfo> confirmCB;
        private readonly Form parentForm;

        public ReaderInfoUpsertDialog(Form context, List<ReaderTypeEntity> readerTypeList,
            Action<ReaderInfo> confirmCB, ReaderInfo? readerTypeInfo = null)
        {
            InitializeComponent();
            parentForm = context;
            defaultInfo = readerTypeInfo;
            Text = defaultInfo == null ? "新增读者信息" : "更新读者信息";
            upsertBtn.Text = defaultInfo == null ? "新增确认" : "更新确认";
            this.confirmCB = confirmCB;
            typeSelect.Items.AddRange(readerTypeList.Select(item => new SelectItem(item.TypeId)
            {
                Text = item.TypeName,
            }).ToArray<object>());
            if (defaultInfo == null) return; // 初始化默认值 
            name.Text = defaultInfo!.Name;
            qq.Text = defaultInfo!.QQ;
            department.Text = defaultInfo!.Department;
            typeSelect.SelectedValue= defaultInfo!.TypeId;
            
        }


        private void upsert_confirm(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(name.Text))
            {
                parentForm.WarnNotification("操作提示", "姓名不能为空");
                return;
            }

            if (string.IsNullOrWhiteSpace(qq.Text) || !decimal.TryParse(qq.Text, out _))
            {
                parentForm.WarnNotification("操作提示", "qq号应该只有数字");
                return;
            }

            if (string.IsNullOrEmpty(department.Text))
            {
                parentForm.WarnNotification("操作提示", "部门不能为空");
                return;
            }

            if (typeSelect.SelectedValue == null)
            {
                parentForm.WarnNotification("操作提示", "没有选择读者类型");
                return;
            }

            var typeId = Convert.ToInt32(typeSelect.SelectedValue);
            if (typeId == 0)
            {
                parentForm.WarnNotification("操作提示", "读者id转换失败，不是一个整数");
                return;
            }

            confirmCB(new ReaderInfo(defaultInfo?.ReaderId, typeId, name.Text, department.Text, qq.Text, 0));
            Close();
        }
    }
}