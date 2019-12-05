﻿
using Microsoft.VisualStudio;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;
using System;
using VSConsoleOutputBeta;

namespace resource.service
{
    internal sealed class Solution : IVsSolutionEvents3
    {
        public static void Connect()
        {
            var a_Context = Package.GetGlobalService(typeof(SVsSolution)) as IVsSolution;
            if (a_Context != null)
            {
                var a_Context1 = (uint)0;
                {
                    a_Context.AdviseSolutionEvents(new Solution(), out a_Context1);
                }
            }
        }

        public static void Disconnect()
        {
        }

        public int OnAfterCloseSolution(object reserved)
        {
            return VSConstants.S_OK;
        }

        public int OnAfterLoadProject(IVsHierarchy stubHierarchy, IVsHierarchy realHierarchy)
        {
            return VSConstants.S_OK;
        }

        public int OnAfterOpenProject(IVsHierarchy hierarchy, int added)
        {
            return VSConstants.S_OK;
        }

        public int OnAfterOpenSolution(object reserved, int newSolution)
        {
            try
            {
                Output.Initialize();
            }
            catch (Exception ex)
            {
                //resource.package.MetaProject.Warning(ex);
            }
            return VSConstants.S_OK;
        }

        public int OnBeforeCloseProject(IVsHierarchy hierarchy, int removed)
        {
            return VSConstants.S_OK;
        }

        public int OnBeforeCloseSolution(object reserved)
        {
            return VSConstants.S_OK;
        }

        public int OnBeforeUnloadProject(IVsHierarchy realHierarchy, IVsHierarchy stubHierarchy)
        {
            return VSConstants.S_OK;
        }

        public int OnQueryCloseProject(IVsHierarchy hierarchy, int removing, ref int cancel)
        {
            return VSConstants.S_OK;
        }

        public int OnQueryCloseSolution(object reserved, ref int cancel)
        {
            return VSConstants.S_OK;
        }

        public int OnQueryUnloadProject(IVsHierarchy realHierarchy, ref int cancel)
        {
            return VSConstants.S_OK;
        }

        public int OnAfterMergeSolution(object pUnkReserved)
        {
            return VSConstants.S_OK;
        }

        public int OnBeforeOpeningChildren(IVsHierarchy pHierarchy)
        {
            return VSConstants.S_OK;
        }

        public int OnAfterOpeningChildren(IVsHierarchy pHierarchy)
        {
            return VSConstants.S_OK;
        }

        public int OnBeforeClosingChildren(IVsHierarchy pHierarchy)
        {
            return VSConstants.S_OK;
        }

        public int OnAfterClosingChildren(IVsHierarchy pHierarchy)
        {
            return VSConstants.S_OK;
        }

        private static object __GetProperty(IVsHierarchy hierarchy, int propId)
        {
            var a_Result = (object)null;
            return a_Result;
        }
    }
}
