Title: Properties
Order: 3
---

# Properties

<table class="table">
  <tbody><tr>
    <th>Property</th>
    <th>Type</th>
    <th>Example</th>
  </tr>
  <tr>
    <td><code>archived</code></td>
    <td><code>Boolean</code></td>
    <td></td>
  </tr>
  <tr>
    <td><code>assigned</code>, <code>assignee</code></td>
    <td><code>String</code></td>
    <td></td>
  </tr>
  <tr>
    <td><code>author</code></td>
    <td><code>String</code></td>
    <td></td>
  </tr>
  <tr>
    <td><code>body</code></td>
    <td><code>String</code></td>
    <td></td>
  </tr>
  <tr>
    <td><code>category</code></td>
    <td><code>String</code></td>
    <td></td>
  </tr>
  <tr>
    <td><code>closed</code></td>
    <td><code>Boolean</code></td>
    <td></td>
  </tr>
  <tr>
    <td><code>commenter</code></td>
    <td><code>String</code></td>
    <td></td>
  </tr>
  <tr>
    <td><code>comment</code></td>
    <td><code>String</code></td>
    <td></td>
  </tr>
  <tr>
    <td><code>commit</code></td>
    <td><code>Boolean</code></td>
    <td></td>
  </tr>
  <tr>
    <td><code>fork</code></td>
    <td><code>Boolean</code></td>
    <td></td>
  </tr>
  <tr>
    <td><code>id</code></td>
    <td><code>Integer</code></td>
    <td></td>
  </tr>
  <tr>
    <td><code>inbox</code></td>
    <td><code>Boolean</code></td>
    <td></td>
  </tr>
  <tr>
    <td><code>involved</code>, <code>involves</code></td>
    <td><code>String</code></td>
    <td></td>
  </tr>
  <tr>
    <td><code>issue</code></td>
    <td><code>Boolean</code></td>
    <td></td>
  </tr>
  <tr>
    <td><code>label</code></td>
    <td><code>String</code></td>
    <td></td>
  </tr>
  <tr>
    <td><code>locked</code></td>
    <td><code>Boolean</code></td>
    <td></td>
  </tr>
  <tr>
    <td><code>mention</code>, <code>mentions</code></td>
    <td><code>String</code></td>
    <td></td>
  </tr>
  <tr>
    <td><code>merged</code></td>
    <td><code>Boolean</code></td>
    <td></td>
  </tr>
  <tr>
    <td><code>merger</code></td>
    <td><code>String</code></td>
    <td></td>
  </tr>
  <tr>
    <td><code>milestone</code></td>
    <td><code>String</code></td>
    <td></td>
  </tr>
  <tr>
    <td><code>muted</code></td>
    <td><code>Boolean</code></td>
    <td></td>
  </tr>
  <tr>
    <td><code>open</code></td>
    <td><code>Boolean</code></td>
    <td></td>
  </tr>
  <tr>
    <td><code>owner</code>, <code>org</code></td>
    <td><code>String</code></td>
    <td></td>
  </tr>
  <tr>
    <td><code>private</code></td>
    <td><code>Boolean</code></td>
    <td></td>
  </tr>
  <tr>
    <td><code>pullrequest</code>, <code>pr</code></td>
    <td><code>Boolean</code></td>
    <td></td>
  </tr>
  <tr>
    <td><code>read</code></td>
    <td><code>Boolean</code></td>
    <td></td>
  </tr>
  <tr>
    <td><code>release</code></td>
    <td><code>Boolean</code></td>
    <td></td>
  </tr>
  <tr>
    <td><code>reopened</code></td>
    <td><code>Boolean</code></td>
    <td></td>
  </tr>
  <tr>
    <td><code>repository</code>, <code>repo</code></td>
    <td><code>String</code></td>
    <td></td>
  </tr>
  <tr>
    <td><code>reviewer</code></td>
    <td><code>String</code></td>
    <td></td>
  </tr>
  <tr>
    <td><code>starred</code></td>
    <td><code>Boolean</code></td>
    <td></td>
  </tr>
  <tr>
    <td><code>title</code></td>
    <td><code>String</code></td>
    <td></td>
  </tr>
  <tr>
    <td><code>unread</code></td>
    <td><code>Boolean</code></td>
    <td></td>
  </tr>
  <tr>
    <td><code>vulnerability</code></td>
    <td><code>Boolean</code></td>
    <td></td>
  </tr>
</tbody>
</table>

# Special cases
<p>To make queries easier to read there are some special keywords in GQL which makes queries easier to read in some places. Using these keywords are completely optional and might be used in cases where the query doesn't quite "read right".</p>
<p>You can use the <code>is:</code> prefix for boolean values. Normally <code>:</code> means contains, but in this case it will evaluate to true if the provided boolean is true.</p>

```custom
is:pullrequest or is:vulnerability
```

<p>translates to</p>

```custom
pullrequest or vulnerability
```