using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractices
{
    public class EncodeDecodeString
    {
        /*
         * Design an algorithm to encode a list of strings to a string. The encoded string is then sent over the network and is decoded back to the original list of strings.

            Please implement encode and decode

            Wechat reply 【Two Sigma】 get the latest requent Interview questions. (wechat id : jiuzhang1104)
            Example
            Example1

            Input: ["lint","code","love","you"]
            Output: ["lint","code","love","you"]
            Explanation:
            One possible encode method is: "lint:;code:;love:;you"
            Example2

            Input: ["we", "say", ":", "yes"]
            Output: ["we", "say", ":", "yes"]
            Explanation:
            One possible encode method is: "we:;say:;:::;yes"
         */

        /*
         * @param strs: a list of strings
         * @return: encodes a list of strings to a single string.
         */
        public String encode(List<String> strs)
        {
            // Encodes a list of strings to a single string.
            return string.Join(":;", strs);
        }

        /*
         * @param str: A string
         * @return: dcodes a single string to a list of strings
         */
        public List<String> decode(String str)
        {
            // Decodes a single string to a list of strings.
            return str.Split(new string[] {":;#"},System.StringSplitOptions.None).ToList();
        }
    }
}
