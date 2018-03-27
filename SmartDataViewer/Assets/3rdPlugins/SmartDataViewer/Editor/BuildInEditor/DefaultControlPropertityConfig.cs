﻿//
//   		Copyright 2017 KeyleXiao.
//     		Contact : Keyle_xiao@hotmail.com 
//
//     		Licensed under the Apache License, Version 2.0 (the "License");
//     		you may not use this file except in compliance with the License.
//     		You may obtain a copy of the License at
//
//     		http://www.apache.org/licenses/LICENSE-2.0
//
//     		Unless required by applicable law or agreed to in writing, software
//     		distributed under the License is distributed on an "AS IS" BASIS,
//     		WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//     		See the License for the specific language governing permissions and
//     		limitations under the License.
//
using System;
using SmartDataViewer;
using UnityEditor;

namespace SmartDataViewer.Editor.BuildInEditor
{

	public class DefaultControlConfigEditor : ConfigEditorSchema<DefaultControlPropertity>
	{
		[MenuItem("SmartDataViewer/Default Control Setting")]
		static public void OpenView()
		{
			DefaultControlConfigEditor w = CreateInstance<DefaultControlConfigEditor>();
			w.ShowUtility();
		}

		public override DefaultControlPropertity CreateValue()
		{
			DefaultControlPropertity r = base.CreateValue();
			return r;
		}

		public override void Initialize()
		{
			base.Initialize();
			SetConfigType(new DefaultControlPropertityConfig());
		}
		protected override void SaveButton()
		{
			EditorConfig.ControlPropertityConfig = DefaultControlPropertityConfig.LoadConfig<DefaultControlPropertityConfig>("{EDITOR}/Config/DefaultControlPropertity");
			base.SaveButton();
		}
	}
}
