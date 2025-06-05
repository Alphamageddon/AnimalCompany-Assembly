// Decompiled with Xera AI Decompiler
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;
using SpatialSys.CommandLib;
using SpatialSys.ObservableState;

namespace AnimalCompany
{
    public class UserWalletMediator : MonoBehaviour
    {
        [CompilerGenerated]
        private sealed class <>c__DisplayClass7_0
        {
            public int diff;

            public <>c__DisplayClass7_0()
            {
            }

            internal Task<IApiRpc> <SaveSoftCurrencyCommand>b__0(CancellationToken token)
            {
                return App.userWalletService.UpdateSoftCurrency(diff, token);
            }
        }

        [CompilerGenerated]
        private sealed class <SaveSoftCurrencyCommand>d__7 : IEnumerator<Command>, IEnumerator, IDisposable
        {
            private int <>1__state;
            private Command <>2__current;
            public UserWalletMediator <>4__this;
            private int <currentAmount>5__2;
            private TaskCommand<IApiRpc> <updateWalletCommand>5__3;

            Command IEnumerator<Command>.Current
            {
                [DebuggerHidden]
                get { return <>2__current; }
            }

            object IEnumerator.Current
            {
                [DebuggerHidden]
                get { return <>2__current; }
            }

            [DebuggerHidden]
            public <SaveSoftCurrencyCommand>d__7(int <>1__state)
            {
                this.<>1__state = <>1__state;
            }

            bool IEnumerator.MoveNext()
            {
                int num = <>1__state;
                UserWalletMediator userWalletMediator = <>4__this;
                switch (num)
                {
                    default:
                        return false;
                    case 0:
                        <>1__state = -1;
                        <>2__current = Commands.Wait(60f);
                        <>1__state = 1;
                        return true;
                    case 1:
                        <>1__state = -1;
                        <currentAmount>5__2 = App.userWallet.softCurrency;
                        if (<currentAmount>5__2 != userWalletMediator._lastSavedSoftCurrencyValue)
                        {
                            <>c__DisplayClass7_0 <>c__DisplayClass7_ = new <>c__DisplayClass7_0();
                            <>c__DisplayClass7_.diff = <currentAmount>5__2 - userWalletMediator._lastSavedSoftCurrencyValue;
                            <updateWalletCommand>5__3 = Commands.Task<IApiRpc>(<>c__DisplayClass7_.<SaveSoftCurrencyCommand>b__0);
                            <>2__current = <updateWalletCommand>5__3;
                            <>1__state = 2;
                            return true;
                        }
                        break;
                    case 2:
                        <>1__state = -1;
                        if (<updateWalletCommand>5__3.isSuccessful)
                        {
                            userWalletMediator._lastSavedSoftCurrencyValue = <currentAmount>5__2;
                        }
                        break;
                }
                return false;
            }

            [DebuggerHidden]
            void IEnumerator.Reset()
            {
                throw new NotSupportedException();
            }

            [DebuggerHidden]
            void IDisposable.Dispose()
            {
            }
        }

        private const int SAVE_SOFT_CURRENCY_INTERVAL = 60;
        private CommandHandle _saveSoftCurrencyHandle;
        private int _lastSavedSoftCurrencyValue;

        public UserWalletMediator()
        {
        }

        private void Awake()
        {
            App.RegisterObserver(this, App.userLoginState.OnChanged(HandleUserLoggedInChanged));
        }

        private void HandleUserLoggedInChanged(StateChangedEventArgs args)
        {
            App.DeregisterObserver(this, App.userWallet.OnSoftCurrencyChanged(HandleUserSoftCurrencyChanged));
            
            if (App.userLoginState.isLoggedIn)
            {
                App.RegisterObserver(this, App.userWallet.OnSoftCurrencyChanged(HandleUserSoftCurrencyChanged));
            }
        }

        private void HandleUserSoftCurrencyChanged(StateChangedEventArgs args)
        {
            if (App.userLoginState.isLoggedIn)
            {
                _lastSavedSoftCurrencyValue = App.userWallet.softCurrency;
                
                if (_saveSoftCurrencyHandle != null && !_saveSoftCurrencyHandle.hasFinalized)
                {
                    return;
                }
                
                _saveSoftCurrencyHandle = App.ExecuteCommand(Commands.Coroutine(SaveSoftCurrencyCommand()), false);
            }
        }

        private void OnDestroy()
        {
            if (_saveSoftCurrencyHandle != null)
            {
                _saveSoftCurrencyHandle.Cancel();
            }
            
            App.DeregisterObserver(this, App.userLoginState.OnChanged(HandleUserLoggedInChanged));
            App.DeregisterObserver(this, App.userWallet.OnSoftCurrencyChanged(HandleUserSoftCurrencyChanged));
        }

        [IteratorStateMachine(typeof(<SaveSoftCurrencyCommand>d__7))]
        private IEnumerator<Command> SaveSoftCurrencyCommand()
        {
            return new <SaveSoftCurrencyCommand>d__7(0)
            {
                <>4__this = this
            };
        }
    }
}