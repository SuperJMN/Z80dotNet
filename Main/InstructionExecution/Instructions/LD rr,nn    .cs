﻿// AUTOGENERATED CODE
//
// Do not make changes directly to this (.cs) file.
// Change LD rr,nn    .tt instead.

namespace Konamiman.Z80dotNet
{
    public partial class Z80InstructionExecutor
    {
        /// <summary>
        /// The LD BC,nn instruction.
        /// </summary>
        byte LD_BC_nn()
        {
            var value = FetchWord();
            FetchFinished();
            Registers.BC = value;
            return 10;
        }

        /// <summary>
        /// The LD DE,nn instruction.
        /// </summary>
        byte LD_DE_nn()
        {
            var value = FetchWord();
            FetchFinished();
            Registers.DE = value;
            return 10;
        }

        /// <summary>
        /// The LD HL,nn instruction.
        /// </summary>
        byte LD_HL_nn()
        {
            var value = FetchWord();
            FetchFinished();
            Registers.HL = value;
            return 10;
        }

        /// <summary>
        /// The LD SP,nn instruction.
        /// </summary>
        byte LD_SP_nn()
        {
            var value = FetchWord();
            FetchFinished();
            Registers.SP = value;
            return 10;
        }

    }
}
