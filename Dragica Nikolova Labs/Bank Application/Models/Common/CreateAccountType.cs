﻿using System;

[Flags]
public enum CreateAccountType : int { None = 0, TransactionAccount = 1, DepositAccount = 2, LoanAccount = 4}