

 document.addEventListener('DOMContentLoaded', function() {
  var clipboard = new ClipboardJS('.btn');

  clipboard.on('success', function(e) {
      console.log(e);
  });

  clipboard.on('error', function(e) {
      console.log(e);
  });
   
   }, false);


  // Copyright (c) 2010 The Chromium Authors. All rights reserved.
2	// Use of this source code is governed by a BSD-style license that can be
3	// found in the LICENSE file.
4	
5	// A generic onclick callback function.
6	function genericOnClick(info, tab) {
7	  console.log("item " + info.menuItemId + " was clicked");
8	  console.log("info: " + JSON.stringify(info));
9	  console.log("tab: " + JSON.stringify(tab));
10	}
11	
12	// Create one test item for each context type.
13	var contexts = ["page","selection","link","editable","image","video",
14	                "audio"];
15	for (var i = 0; i < contexts.length; i++) {
16	  var context = contexts[i];
17	  var title = "Test '" + context + "' menu item";
18	  var id = chrome.contextMenus.create({"title": title, "contexts":[context],
19	                                       "onclick": genericOnClick});
20	  console.log("'" + context + "' item:" + id);
21	}
22	
23	
24	// Create a parent item and two children.
25	var parent = chrome.contextMenus.create({"title": "Test parent item"});
26	var child1 = chrome.contextMenus.create(
27	  {"title": "Child 1", "parentId": parent, "onclick": genericOnClick});
28	var child2 = chrome.contextMenus.create(
29	  {"title": "Child 2", "parentId": parent, "onclick": genericOnClick});
30	console.log("parent:" + parent + " child1:" + child1 + " child2:" + child2);
31	
32	
33	// Create some radio items.
34	function radioOnClick(info, tab) {
35	  console.log("radio item " + info.menuItemId +
36	              " was clicked (previous checked state was "  +
37	              info.wasChecked + ")");
38	}
39	var radio1 = chrome.contextMenus.create({"title": "Radio 1", "type": "radio",
40	                                         "onclick":radioOnClick});
41	var radio2 = chrome.contextMenus.create({"title": "Radio 2", "type": "radio",
42	                                         "onclick":radioOnClick});
43	console.log("radio1:" + radio1 + " radio2:" + radio2);
44	
45	
46	// Create some checkbox items.
47	function checkboxOnClick(info, tab) {
48	  console.log(JSON.stringify(info));
49	  console.log("checkbox item " + info.menuItemId +
50	              " was clicked, state is now: " + info.checked +
51	              "(previous state was " + info.wasChecked + ")");
52	
53	}
54	var checkbox1 = chrome.contextMenus.create(
55	  {"title": "Checkbox1", "type": "checkbox", "onclick":checkboxOnClick});
56	var checkbox2 = chrome.contextMenus.create(
57	  {"title": "Checkbox2", "type": "checkbox", "onclick":checkboxOnClick});
58	console.log("checkbox1:" + checkbox1 + " checkbox2:" + checkbox2);
59	
60	
61	// Intentionally create an invalid item, to show off error checking in the
62	// create callback.
63	console.log("About to try creating an invalid item - an error about " +
64	            "item 999 should show up");
65	chrome.contextMenus.create({"title": "Oops", "parentId":999}, function() {
66	  if (chrome.extension.lastError) {
67	    console.log("Got expected error: " + chrome.extension.lastError.message);
68	  }
69	});
