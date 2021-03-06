﻿// Copyright 2012-2013 Alalf <alalf.iQLc_at_gmail.com>
//
// This file is part of SCFF-DirectShow-Filter(SCFF DSF).
//
// SCFF DSF is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// SCFF DSF is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with SCFF DSF.  If not, see <http://www.gnu.org/licenses/>.

/// @file SCFF.Common/GUI/IBindingProfile.cs
/// @copydoc SCFF::Common::GUI::IBindingProfile

namespace SCFF.Common.GUI {

/// 自前Profile->Controlデータバインディング用インタフェース
///
/// @attention どうしてもINotifyPropertyChangedなどの
///            リフレクションを使いたくなかったためやむなく用意した
public interface IBindingProfile {
  /// Control->Profile可能にする
  bool CanChangeProfile { get; }

  /// Profile(CurrentViewのみ)->Control書き換え
  void OnCurrentLayoutElementChanged();

  /// Profile.CurrentIndex/Profile.LayoutElementCountなどが変更された場合の
  /// Profile->Control書き換え
  void OnProfileChanged();
}
}   // namespace SCFF.Common.GUI
