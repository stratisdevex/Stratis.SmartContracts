﻿namespace Stratis.SmartContracts
{
    public interface IMessage
    {
        /// <summary>
        /// The address of the contract currently being executed.
        /// </summary>
        Address ContractAddress { get; }

        /// <summary>
        /// The address that called this contract.
        /// </summary>
        Address Sender { get; }

        /// <summary>
        /// The number of coins sent with this call.
        /// </summary>
        ulong Value { get; }
    }
}